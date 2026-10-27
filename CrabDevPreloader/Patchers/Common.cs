using BepInEx;
using Mono.Cecil;
using System.IO;
using System.Linq;

namespace CrabDevPreloader.Patchers
{
    internal static class Common
    {
        internal static AssemblyDefinition il2CppmscorlibAssembly;

        internal static TypeDefinition il2CppSystemObjectType;

        internal static MethodDefinition il2CppSystemObjectIntPtrCtor;


        internal static void Init()
        {
            il2CppmscorlibAssembly = ReadUnhollowedAssembly("Il2Cppmscorlib.dll");

            il2CppSystemObjectType = il2CppmscorlibAssembly.MainModule.GetType("Il2CppSystem.Object");

            il2CppSystemObjectIntPtrCtor = il2CppSystemObjectType.Methods.First(m =>
                m.IsConstructor &&
                !m.IsStatic &&
                m.Parameters.Count == 1 &&
                m.Parameters[0].ParameterType == il2CppmscorlibAssembly.MainModule.TypeSystem.IntPtr);
        }


        internal static AssemblyDefinition ReadUnhollowedAssembly(string assemblyName)
            => AssemblyDefinition.ReadAssembly(Path.Combine(Paths.BepInExRootPath, "unhollowed", assemblyName));


        internal static bool MemberEquals(this MemberReference a, MemberReference b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (a == null || b == null)
                return false;

            return a.FullName == b.FullName &&
                a.Module.Assembly.FullName == b.Module.Assembly.FullName;
        }
    }
}