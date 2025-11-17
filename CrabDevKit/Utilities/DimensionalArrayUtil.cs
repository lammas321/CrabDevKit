using System;
using System.Runtime.InteropServices;
using UnhollowerBaseLib;

// TODO: TEST THIS WORKS xD

namespace CrabDevKit.Utilities
{
    public static class DimensionalArrayUtil
    {
        public static T[,] ToManaged2D<T>(Il2CppObjectBase il2CppArray)
        {
            if (il2CppArray == null || il2CppArray.Pointer == IntPtr.Zero)
                throw new ArgumentNullException(nameof(il2CppArray));

            var sysArray = new Il2CppSystem.Array(il2CppArray.Pointer);
            if (sysArray.Rank != 2)
                throw new InvalidOperationException($"Expected rank-2 array, got rank {sysArray.Rank}");

            int dim0 = sysArray.GetLength(0);
            int dim1 = sysArray.GetLength(1);
            T[,] managed = new T[dim0, dim1];

            for (int i = 0; i < dim0; i++)
                for (int j = 0; j < dim1; j++)
                {
                    object value = sysArray.GetValue(i, j);
                    if (value is Il2CppObjectBase il2CppObj && typeof(T).IsAssignableFrom(il2CppObj.GetType()))
                        managed[i, j] = (T)(object)il2CppObj;
                    else if (value != null)
                        managed[i, j] = (T)Convert.ChangeType(value, typeof(T));
                    else
                        managed[i, j] = default;
                }

            return managed;
        }

        public static Il2CppObjectBase FromManaged2D<T>(T[,] managed)
        {
            if (managed == null)
                throw new ArgumentNullException(nameof(managed));

            int dim0 = managed.GetLength(0);
            int dim1 = managed.GetLength(1);

            IntPtr elementClass = Il2CppClassPointerStore<T>.NativeClassPtr;
            if (elementClass == IntPtr.Zero)
                throw new InvalidOperationException($"Type {typeof(T)} is not defined in IL2CPP.");

            IntPtr arrayPtr = CreateArray(elementClass, [dim0, dim1]);
            Il2CppSystem.Array il2CppArray = new(arrayPtr);

            for (int i = 0; i < dim0; i++)
                for (int j = 0; j < dim1; j++)
                {
                    object val = managed[i, j];

                    if (val == null)
                    {
                        il2CppArray.SetValue(null, i, j);
                    }
                    else if (val is Il2CppObjectBase ilObj)
                    {
                        il2CppArray.SetValue(ilObj.TryCast<Il2CppSystem.Object>(), i, j);
                    }
                    else if (val is string s)
                    {
                        IntPtr ilStrPtr = IL2CPP.ManagedStringToIl2Cpp(s);
                        il2CppArray.SetValue(new Il2CppSystem.String(ilStrPtr), i, j);
                    }
                    else if (val.GetType().IsValueType)
                    {
                        IntPtr tempPtr = Marshal.AllocHGlobal(Marshal.SizeOf(val.GetType()));
                        Marshal.StructureToPtr(val, tempPtr, false);

                        IntPtr boxed = IL2CPP.il2cpp_value_box(elementClass, tempPtr);

                        Marshal.FreeHGlobal(tempPtr);

                        il2CppArray.SetValue(new Il2CppSystem.Object(boxed), i, j);
                    }
                    else
                        throw new NotImplementedException($"Unable to box type {val.GetType()}.");
                }

            return new Il2CppObjectBase(arrayPtr);
        }
        
        private static IntPtr CreateArray(IntPtr elementClass, int[] dims)
        {
            if (dims == null || dims.Length == 0) throw new ArgumentException(nameof(dims));
            int rank = dims.Length;

            ulong[] lengths = new ulong[rank];
            ulong[] lowerBounds = new ulong[rank];
            for (int i = 0; i < rank; i++)
            {
                lengths[i] = (ulong)dims[i];
                lowerBounds[i] = 0UL;
            }

            return IL2CPP.il2cpp_array_new_full(elementClass, ref lengths[0], ref lowerBounds[0]);
        }
    }
}