using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Linq;
using static CrabDevPreloader.CrabDevPreloader;

namespace CrabDevPreloader.Patchers
{
    internal static class AssetBundlePatcher
    {
        internal static void Patch(TypeDefinition type)
        {
            Logger.LogMessage("Patching AssetBundle...");

            RestoreBaseType(type);
            RestoreIntPtrCtor(type);

            Logger.LogMessage("Patched AssetBundle");
        }


        private static void RestoreBaseType(TypeDefinition type)
        {
            if (type.BaseType.MemberEquals(Common.il2CppSystemObjectType))
            {
                Logger.LogInfo("AssetBundle already inherits Il2CppSystem.Object, skipping");
                return;
            }

            Logger.LogDebug("Restoring AssetBundle.BaseType to Il2CppSystem.Object...");
            
            type.BaseType = type.Module.ImportReference(Common.il2CppSystemObjectType);
            Logger.LogInfo("Restored AssetBundle.BaseType to Il2CppSystem.Object");
        }


        private static void RestoreIntPtrCtor(TypeDefinition type)
        {
            if (type.Methods.Any(m =>
                m.IsConstructor &&
                !m.IsStatic &&
                m.Parameters.Count == 1 &&
                m.Parameters[0].ParameterType.MemberEquals(type.Module.TypeSystem.IntPtr)))
            {
                Logger.LogInfo("AssetBundle(IntPtr) constructor already exists, skipping");
                return;
            }

            Logger.LogDebug("Restoring AssetBundle(IntPtr) constructor...");

            var ctor = new MethodDefinition(
                ".ctor",
                MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName,
                type.Module.TypeSystem.Void
            );

            ctor.Parameters.Add(new ParameterDefinition(
                "ptr",
                ParameterAttributes.None,
                type.Module.TypeSystem.IntPtr
            ));

            Logger.LogDebug("Writing AssetBundle(IntPtr) constructor body...");

            var il = ctor.Body.GetILProcessor();

            Logger.LogDebug(" base(ptr);");
            il.Append(il.Create(OpCodes.Ldarg_0));
            il.Append(il.Create(OpCodes.Ldarg_1));
            il.Append(il.Create(OpCodes.Call, type.Module.ImportReference(Common.il2CppSystemObjectIntPtrCtor)));

            il.Append(il.Create(OpCodes.Ret));

            type.Methods.Add(ctor);
            Logger.LogInfo("Restored AssetBundle(IntPtr) constructor");
        }
    }
}