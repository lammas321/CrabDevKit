using BepInEx;
using BepInEx.IL2CPP.Hook;
using BepInEx.Preloader.Core.Patching;
using HarmonyLib;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using MonoOpCodes = Mono.Cecil.Cil.OpCodes;
using SystemOpCodes = System.Reflection.Emit.OpCodes;

namespace CrabDevPreloader
{
    [PatcherPluginInfo(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public sealed class CrabDevPreloader : BasePatcher
    {
        internal static CrabDevPreloader Instance { get; private set; }

        private MethodDefinition _downloadHandlerCtor;


        public override void Initialize()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            Instance = this;

            Log.LogInfo("Applying Harmony patches...");
            
            Harmony harmony = new(MyPluginInfo.PLUGIN_NAME);
            harmony.PatchAll(typeof(CrabDevPreloader));

            Log.LogInfo($"Initialized [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }


        private AssemblyDefinition ReadCoreAssembly(string assemblyName)
        {
            return AssemblyDefinition.ReadAssembly(Path.Combine(Paths.BepInExRootPath, "core", assemblyName));
        }

        private AssemblyDefinition ReadUnhollowedAssembly(string assemblyName)
        {
            return AssemblyDefinition.ReadAssembly(Path.Combine(Paths.BepInExRootPath, "unhollowed", assemblyName));
        }
        


        [TargetType("UnityEngine.AssetBundleModule.dll", "UnityEngine.AssetBundle")]
        public void PatchAssetBundle(TypeDefinition assetBundleType)
        {
            Log.LogInfo("Patching AssetBundle...");

            PatchAssetBundleBaseType(assetBundleType);
            PatchAssetBundleIntPtrCtor(assetBundleType);

            Log.LogInfo("Patched AssetBundle");
        }


        private void PatchAssetBundleBaseType(TypeDefinition assetBundleType)
        {
            var unhollowerBaseLibAssembly = ReadCoreAssembly("UnhollowerBaseLib.dll");

            var il2CppObjectBaseType = unhollowerBaseLibAssembly.MainModule.GetType("UnhollowerBaseLib.Il2CppObjectBase");


            // Only patch if the base type is not already Il2CppObjectBase
            if (assetBundleType.BaseType?.FullName == il2CppObjectBaseType.FullName)
            {
                Log.LogInfo("AssetBundle already inherits Il2CppObjectBase, skipping");
                return;
            }


            // Set the base type to Il2CppObjectBase
            assetBundleType.BaseType = assetBundleType.Module.ImportReference(il2CppObjectBaseType);
            Log.LogInfo("Set AssetBundle.BaseType = Il2CppObjectBase");
        }


        private void PatchAssetBundleIntPtrCtor(TypeDefinition assetBundleType)
        {
            // Skip if ctor already exists
            if (assetBundleType.Methods.Any(m =>
                m.IsConstructor &&
                !m.IsStatic &&
                m.Parameters.Count == 1 &&
                m.Parameters[0].ParameterType.FullName == "System.IntPtr"))
            {
                Log.LogInfo("AssetBundle(IntPtr) constructor already exists, skipping");
                return;
            }


            // Create AssetBundle(IntPtr ptr) constructor
            MethodDefinition ctor = new(
                ".ctor",
                MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName,
                assetBundleType.Module.TypeSystem.Void
            );

            ctor.Parameters.Add(new ParameterDefinition(
                "ptr",
                ParameterAttributes.None,
                assetBundleType.Module.TypeSystem.IntPtr
            ));

            var il = ctor.Body.GetILProcessor();


            // base(ptr)
            var unhollowerBaseLibAssembly = ReadCoreAssembly("UnhollowerBaseLib.dll");

            var il2CppObjectBaseType = unhollowerBaseLibAssembly.MainModule.GetType("UnhollowerBaseLib.Il2CppObjectBase");

            var il2CppObjectBaseCtor = il2CppObjectBaseType.Methods
                .First(m =>
                    m.IsConstructor &&
                    !m.IsStatic &&
                    m.Parameters.Count == 1 &&
                    m.Parameters[0].ParameterType.FullName == "System.IntPtr");

            il.Append(il.Create(MonoOpCodes.Ldarg_0));          // this
            il.Append(il.Create(MonoOpCodes.Ldarg_1));          // ptr argument
            il.Append(il.Create(MonoOpCodes.Call, assetBundleType.Module.ImportReference(il2CppObjectBaseCtor))); // call Il2CppObjectBase ctor
            il.Append(il.Create(MonoOpCodes.Ret));              // return

            assetBundleType.Methods.Add(ctor);
            Log.LogInfo("Injected AssetBundle(IntPtr) constructor");
        }



        [TargetType("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking.DownloadHandler")]
        public void PatchDownloadHandler(TypeDefinition downloadHandlerType)
        {
            Log.LogInfo("Patching DownloadHandler...");


            // Skip if ctor already exists
            if (downloadHandlerType.Methods.Any(m =>
                m.IsConstructor &&
                !m.IsStatic &&
                m.Parameters.Count == 0))
            {
                Log.LogInfo("DownloadHandler() constructor already exists, skipping");
                return;
            }


            // Create DownloadHandler() constructor
            _downloadHandlerCtor = new MethodDefinition(
                ".ctor",
                MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName,
                downloadHandlerType.Module.TypeSystem.Void
            );

            var il = _downloadHandlerCtor.Body.GetILProcessor();


            // base()
            var il2CppSystemmscorlibAssembly = ReadUnhollowedAssembly("Il2Cppmscorlib.dll");

            var il2CppSystemObjectType = il2CppSystemmscorlibAssembly.MainModule.GetType("Il2CppSystem.Object");

            var baseCtor = il2CppSystemObjectType.Methods
                .First(m =>
                    m.IsConstructor &&
                    !m.IsStatic &&
                    m.Parameters.Count == 0);

            il.Append(il.Create(MonoOpCodes.Ldarg_0));          // this
            il.Append(il.Create(MonoOpCodes.Call, downloadHandlerType.Module.ImportReference(baseCtor))); // call base ctor
            il.Append(il.Create(MonoOpCodes.Ret));              // return

            downloadHandlerType.Methods.Add(_downloadHandlerCtor);
            Log.LogInfo("Injected DownloadHandler() constructor");
        }



        [TargetType("UnityEngine.UnityWebRequestTextureModule.dll", "UnityEngine.Networking.DownloadHandlerTexture")]
        public void PatchDownloadHandlerTexture(TypeDefinition downloadHandlerTextureType)
        {
            Log.LogInfo("Patching DownloadHandlerTexture...");


            // Skip if ctor already exists
            if (downloadHandlerTextureType.Methods.Any(m =>
                m.IsConstructor &&
                !m.IsStatic &&
                m.Parameters.Count == 1 &&
                m.Parameters[0].ParameterType.FullName == "System.IntPtr"))
            {
                Log.LogInfo("DownloadHandlerTexture(IntPtr) constructor already exists, skipping");
                return;
            }


            // Create DownloadHandlerTexture(IntPtr ptr) constructor
            MethodDefinition ptrCtor = new(
                ".ctor",
                MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName,
                downloadHandlerTextureType.Module.TypeSystem.Void
            );

            ptrCtor.Parameters.Add(new ParameterDefinition(
                "ptr",
                ParameterAttributes.None,
                downloadHandlerTextureType.Module.TypeSystem.IntPtr
            ));

            var ptrIl = ptrCtor.Body.GetILProcessor();


            // base(ptr)
            var downloadHandlerCtor = _downloadHandlerCtor.DeclaringType.Methods
                .First(m =>
                    m.IsConstructor &&
                    !m.IsStatic &&
                    m.Parameters.Count == 1 &&
                    m.Parameters[0].ParameterType.FullName == "System.IntPtr");

            ptrIl.Append(ptrIl.Create(MonoOpCodes.Ldarg_0));          // this
            ptrIl.Append(ptrIl.Create(MonoOpCodes.Ldarg_1));          // ptr argument
            ptrIl.Append(ptrIl.Create(MonoOpCodes.Call, downloadHandlerTextureType.Module.ImportReference(downloadHandlerCtor))); // call DownloadHandler ctor
            ptrIl.Append(ptrIl.Create(MonoOpCodes.Ret));              // return

            downloadHandlerTextureType.Methods.Add(ptrCtor);
            Log.LogInfo("Injected DownloadHandlerTexture(IntPtr) constructor");


            var coreAssembly = ReadUnhollowedAssembly("UnityEngine.CoreModule.dll");

            var texture2DType = coreAssembly.MainModule.GetType("UnityEngine.Texture2D");

            var webRequestAssembly = ReadUnhollowedAssembly("UnityEngine.UnityWebRequestModule.dll");

            var unityWebRequestType = webRequestAssembly.MainModule.GetType("UnityEngine.Networking.UnityWebRequest");

            var unhollowerBaseLibAssembly = ReadCoreAssembly("UnhollowerBaseLib.dll");

            var il2CppObjectBaseType = unhollowerBaseLibAssembly.MainModule.GetType("UnhollowerBaseLib.Il2CppObjectBase");


            // Only patch if the base type is not already Il2CppObjectBase
            if (downloadHandlerTextureType.BaseType?.FullName == _downloadHandlerCtor.DeclaringType.FullName)
            {
                Log.LogInfo("DownloadHandlerTexture already inherits DownloadHandler, skipping");
                return;
            }


            // Set the base type to Il2CppObjectBase
            downloadHandlerTextureType.BaseType = downloadHandlerTextureType.Module.ImportReference(_downloadHandlerCtor.DeclaringType);
            Log.LogInfo("Set DownloadHandlerTexture.BaseType = DownloadHandler");

            // ------------------------------------------------------------
            // Add missing fields
            // ------------------------------------------------------------

            void AddField(string name, TypeReference fieldType)
            {
                if (downloadHandlerTextureType.Fields.Any(f => f.Name == name))
                    return;

                downloadHandlerTextureType.Fields.Add(new FieldDefinition(
                    name,
                    FieldAttributes.Private,
                    downloadHandlerTextureType.Module.ImportReference(fieldType)));
            }

            AddField("mTexture", texture2DType);
            AddField("mHasTexture", downloadHandlerTextureType.Module.TypeSystem.Boolean);
            AddField("mNonReadable", downloadHandlerTextureType.Module.TypeSystem.Boolean);

            // ------------------------------------------------------------
            // Add parameterless constructor
            // ------------------------------------------------------------

            if (!downloadHandlerTextureType.Methods.Any(m => m.IsConstructor && !m.IsStatic && m.Parameters.Count == 0))
            {
                var ctor = new MethodDefinition(".ctor",
                    MethodAttributes.Public |
                    MethodAttributes.HideBySig |
                    MethodAttributes.SpecialName |
                    MethodAttributes.RTSpecialName,
                    downloadHandlerTextureType.Module.TypeSystem.Void);

                var il = ctor.Body.GetILProcessor();

                var internalCreate = downloadHandlerTextureType.Methods
                    .First(m => m.Name == "InternalCreateTexture");

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Call, downloadHandlerTextureType.Module.ImportReference(_downloadHandlerCtor)));

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldc_I4_1));
                il.Append(il.Create(MonoOpCodes.Call, internalCreate));

                il.Append(il.Create(MonoOpCodes.Ret));

                downloadHandlerTextureType.Methods.Add(ctor);
                Log.LogInfo("Injected DownloadHandlerTexture()");
            }

            // ------------------------------------------------------------
            // Add bool constructor
            // ------------------------------------------------------------

            if (!downloadHandlerTextureType.Methods.Any(m => m.IsConstructor && !m.IsStatic && m.Parameters.Count == 1 && m.Parameters[0].ParameterType == downloadHandlerTextureType.Module.TypeSystem.Boolean))
            {
                var ctor = new MethodDefinition(".ctor",
                    MethodAttributes.Public |
                    MethodAttributes.HideBySig |
                    MethodAttributes.SpecialName |
                    MethodAttributes.RTSpecialName,
                    downloadHandlerTextureType.Module.TypeSystem.Void);

                ctor.Parameters.Add(new ParameterDefinition(
                    "readable",
                    ParameterAttributes.None,
                    downloadHandlerTextureType.Module.TypeSystem.Boolean));

                var il = ctor.Body.GetILProcessor();

                var internalCreate = downloadHandlerTextureType.Methods.First(m =>
                    m.Name == "InternalCreateTexture");

                var mNonReadableField = downloadHandlerTextureType.Fields.First(f => f.Name == "mNonReadable");
                
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Call, downloadHandlerTextureType.Module.ImportReference(_downloadHandlerCtor)));

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldarg_1));
                il.Append(il.Create(MonoOpCodes.Call, internalCreate));

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldarg_1));
                il.Append(il.Create(MonoOpCodes.Ldc_I4_0));
                il.Append(il.Create(MonoOpCodes.Ceq));
                il.Append(il.Create(MonoOpCodes.Stfld, mNonReadableField));

                il.Append(il.Create(MonoOpCodes.Ret));

                downloadHandlerTextureType.Methods.Add(ctor);
                Log.LogInfo("Injected DownloadHandlerTexture(bool)");
            }

            // ------------------------------------------------------------
            // Replace InternalGetTexture()
            // ------------------------------------------------------------

            var internalGetTexture = downloadHandlerTextureType.Methods.First(m => m.Name == "InternalGetTexture");

            if (internalGetTexture.Body.Instructions.Any(i =>
                i.OpCode == MonoOpCodes.Newobj &&
                i.Operand is MethodReference mr &&
                mr.DeclaringType.FullName.Contains("NotSupportedException")))
            {
                internalGetTexture.Body = new MethodBody(internalGetTexture)
                {
                    InitLocals = false,
                    MaxStackSize = 3
                };
                var il = internalGetTexture.Body.GetILProcessor();

                var mTexture = downloadHandlerTextureType.Fields.First(f => f.Name == "mTexture");
                var mHasTexture = downloadHandlerTextureType.Fields.First(f => f.Name == "mHasTexture");
                var mNonReadable = downloadHandlerTextureType.Fields.First(f => f.Name == "mNonReadable");

                var internalGetTextureNative = downloadHandlerTextureType.Methods.First(m => m.Name == "InternalGetTextureNative");

                var getData = downloadHandlerTextureType.Methods.First(m => m.Name == "GetData");

                var textureCtor = texture2DType.Methods
                    .First(m =>
                        m.IsConstructor &&
                        !m.IsStatic &&
                        m.Parameters.Count == 2);

                var imageConversionModule = ReadUnhollowedAssembly("UnityEngine.ImageConversionModule.dll");

                var imageConversionType = imageConversionModule.MainModule.GetType("UnityEngine.ImageConversion");

                var loadImage = imageConversionType.Methods.First(m => m.Name == "LoadImage");

                /* Labels */
                var label_else = il.Create(MonoOpCodes.Nop);
                var label_afterHasTextureBlock = il.Create(MonoOpCodes.Nop);
                var label_return = il.Create(MonoOpCodes.Nop);

                /* if (!mHasTexture) goto else */
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldfld, mHasTexture));
                il.Append(il.Create(MonoOpCodes.Brfalse, label_else));

                /* --- mHasTexture == true --- */
                /* if (mTexture != null) goto afterHasTextureBlock */
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldfld, mTexture));
                il.Append(il.Create(MonoOpCodes.Brtrue, label_afterHasTextureBlock));

                /* mTexture = new Texture2D(2,2) */
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldc_I4_2));
                il.Append(il.Create(MonoOpCodes.Ldc_I4_2));
                il.Append(il.Create(MonoOpCodes.Newobj, downloadHandlerTextureType.Module.ImportReference(textureCtor)));
                il.Append(il.Create(MonoOpCodes.Stfld, mTexture));

                /* LoadImage(mTexture, GetData(), mNonReadable) */
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldfld, mTexture));
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Callvirt, getData));
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldfld, mNonReadable));
                il.Append(il.Create(MonoOpCodes.Call, downloadHandlerTextureType.Module.ImportReference(loadImage)));
                il.Append(il.Create(MonoOpCodes.Pop));

                il.Append(label_afterHasTextureBlock);
                il.Append(il.Create(MonoOpCodes.Br, label_return));

                /* --- else block --- */
                il.Append(label_else);

                /* if (mTexture != null) goto return */
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldfld, mTexture));
                il.Append(il.Create(MonoOpCodes.Brtrue, label_return));

                /* mTexture = InternalGetTextureNative() */
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Call, internalGetTextureNative));
                il.Append(il.Create(MonoOpCodes.Stfld, mTexture));

                /* mHasTexture = true */
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldc_I4_1));
                il.Append(il.Create(MonoOpCodes.Stfld, mHasTexture));

                /* return mTexture */
                il.Append(label_return);
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldfld, mTexture));
                il.Append(il.Create(MonoOpCodes.Ret));

                Log.LogInfo("Restored InternalGetTexture()");
            }

            // ------------------------------------------------------------
            // Restore GetContent (inline GetCheckedDownloader logic)
            // ------------------------------------------------------------

            var getContent = downloadHandlerTextureType.Methods
                .First(m => m.Name == "GetContent");

            if (getContent.Body.Instructions.Any(i =>
                i.OpCode == MonoOpCodes.Newobj &&
                i.Operand is MethodReference mr &&
                mr.DeclaringType.FullName.Contains("NotSupportedException")))
            {
                getContent.Body = new MethodBody(getContent)
                {
                    InitLocals = false,
                    MaxStackSize = 3
                };

                var il = getContent.Body.GetILProcessor();

                // -----------------------------------------
                // Resolve corlib exceptions
                // -----------------------------------------

                var corlib = downloadHandlerTextureType.Module.AssemblyResolver.Resolve((AssemblyNameReference)downloadHandlerTextureType.Module.TypeSystem.CoreLibrary);

                var nullRefCtor = downloadHandlerTextureType.Module.ImportReference(
                    corlib.MainModule
                        .GetType("System.NullReferenceException")
                        .Methods.First(m =>
                            m.IsConstructor &&
                            m.Parameters.Count == 1 &&
                            m.Parameters[0].ParameterType.FullName == "System.String"));

                var invalidOpCtor = downloadHandlerTextureType.Module.ImportReference(
                    corlib.MainModule
                        .GetType("System.InvalidOperationException")
                        .Methods.First(m =>
                            m.IsConstructor &&
                            m.Parameters.Count == 1 &&
                            m.Parameters[0].ParameterType.FullName == "System.String"));

                // -----------------------------------------
                // Resolve required UnityWebRequest members
                // -----------------------------------------

                var isDoneGetter = downloadHandlerTextureType.Module.ImportReference(
                    unityWebRequestType.Methods.First(m => m.Name == "get_isDone"));

                var resultGetter = downloadHandlerTextureType.Module.ImportReference(
                    unityWebRequestType.Methods.First(m => m.Name == "get_result"));

                var errorGetter = downloadHandlerTextureType.Module.ImportReference(
                    unityWebRequestType.Methods.First(m => m.Name == "get_error"));

                var downloadHandlerGetter = downloadHandlerTextureType.Module.ImportReference(
                    unityWebRequestType.Methods.First(m => m.Name == "get_downloadHandler"));

                var il2CppObjectBasePointerGetter = downloadHandlerTextureType.Module.ImportReference(
                    il2CppObjectBaseType.Methods.First(m => m.Name == "get_Pointer"));

                var textureGetter = downloadHandlerTextureType.Module.ImportReference(
                    downloadHandlerTextureType.Methods.First(m => m.Name == "get_texture"));

                var resultEnum = unityWebRequestType.NestedTypes
                    .First(t => t.Name == "Result");

                // -----------------------------------------
                // Build IL
                // -----------------------------------------

                var throwNull = il.Create(MonoOpCodes.Nop);
                var continue1 = il.Create(MonoOpCodes.Nop);
                var continue2 = il.Create(MonoOpCodes.Nop);

                // if (www == null)
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Brfalse_S, throwNull));

                // if (!www.isDone)
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Callvirt, isDoneGetter));
                il.Append(il.Create(MonoOpCodes.Brtrue_S, continue1));

                il.Append(il.Create(MonoOpCodes.Ldstr, "Cannot get content from an unfinished UnityWebRequest object"));
                il.Append(il.Create(MonoOpCodes.Newobj, invalidOpCtor));
                il.Append(il.Create(MonoOpCodes.Throw));

                il.Append(continue1);

                // if (www.result == ProtocolError)
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Callvirt, resultGetter));
                il.Append(il.Create(MonoOpCodes.Ldc_I4_3));
                il.Append(il.Create(MonoOpCodes.Bne_Un_S, continue2));

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Callvirt, errorGetter));
                il.Append(il.Create(MonoOpCodes.Newobj, invalidOpCtor));
                il.Append(il.Create(MonoOpCodes.Throw));

                il.Append(continue2);

                // return new DownloadHandlerTexture(www.downloadHandler.Pointer).texture;
                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Callvirt, downloadHandlerGetter));
                il.Append(il.Create(MonoOpCodes.Callvirt, il2CppObjectBasePointerGetter));
                il.Append(il.Create(MonoOpCodes.Newobj, ptrCtor));
                il.Append(il.Create(MonoOpCodes.Callvirt, textureGetter));
                il.Append(il.Create(MonoOpCodes.Ret));

                // throw null block
                il.Append(throwNull);
                il.Append(il.Create(MonoOpCodes.Ldstr, "Cannot get content from a null UnityWebRequest object"));
                il.Append(il.Create(MonoOpCodes.Newobj, nullRefCtor));
                il.Append(il.Create(MonoOpCodes.Throw));

                Log.LogInfo("Restored GetContent()");
            }
        }



        [TargetType("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking.UnityWebRequest")]
        public void PatchUnityWebRequest(TypeDefinition unityWebRequestType)
        {
            Log.LogInfo("Patching UnityWebRequest...");

            if (!unityWebRequestType.Methods.Any(m =>
                m.IsConstructor &&
                !m.IsStatic &&
                m.Parameters.Count == 4 &&
                m.Parameters[0].ParameterType.FullName == "System.String" &&
                m.Parameters[1].ParameterType.FullName == "System.String" &&
                m.Parameters[2].ParameterType.FullName == "UnityEngine.Networking.DownloadHandler" &&
                m.Parameters[3].ParameterType.FullName == "UnityEngine.Networking.UploadHandler"))
            {
                var ctor = new MethodDefinition(".ctor",
                    MethodAttributes.Public |
                    MethodAttributes.HideBySig |
                    MethodAttributes.SpecialName |
                    MethodAttributes.RTSpecialName,
                    unityWebRequestType.Module.TypeSystem.Void);

                ctor.Parameters.Add(new ParameterDefinition(
                    "url",
                    ParameterAttributes.None,
                    unityWebRequestType.Module.TypeSystem.String));

                ctor.Parameters.Add(new ParameterDefinition(
                    "method",
                    ParameterAttributes.None,
                    unityWebRequestType.Module.TypeSystem.String));

                var downloadHandler = unityWebRequestType.Module.Types.First(t => t.Name == "DownloadHandler");

                ctor.Parameters.Add(new ParameterDefinition(
                    "downloadHandler",
                    ParameterAttributes.None,
                    downloadHandler));

                var uploadHandler = unityWebRequestType.Module.Types.First(t => t.Name == "UploadHandler");

                var uploadHandlerParam = new ParameterDefinition(
                    "uploadHandler",
                    ParameterAttributes.None,
                    uploadHandler);

                ctor.Parameters.Add(uploadHandlerParam);

                var il = ctor.Body.GetILProcessor();


                var il2CppSystemmscorlibAssembly = ReadUnhollowedAssembly("Il2Cppmscorlib.dll");

                var il2CppSystemObjectType = il2CppSystemmscorlibAssembly.MainModule.GetType("Il2CppSystem.Object");

                var baseCtor = il2CppSystemObjectType.Methods
                    .First(m =>
                        m.IsConstructor &&
                        !m.IsStatic &&
                        m.Parameters.Count == 0);

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Call, unityWebRequestType.Module.ImportReference(baseCtor)));

                var createMethod = unityWebRequestType.Methods.First(m => m.Name == "Create");

                var setPtr = unityWebRequestType.Methods.First(m => m.Name == "set_m_Ptr");

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Call, createMethod));
                il.Append(il.Create(MonoOpCodes.Call, setPtr));

                var internalSetDefaultsMethod = unityWebRequestType.Methods.First(m => m.Name == "InternalSetDefaults");

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Call, internalSetDefaultsMethod));

                var setUrl = unityWebRequestType.Methods.First(m => m.Name == "set_url");

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldarg_1));
                il.Append(il.Create(MonoOpCodes.Call, setUrl));

                var setMethod = unityWebRequestType.Methods.First(m => m.Name == "set_method");

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldarg_2));
                il.Append(il.Create(MonoOpCodes.Call, setMethod));

                var setDownloadHandler = unityWebRequestType.Methods.First(m => m.Name == "set_downloadHandler");

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldarg_3));
                il.Append(il.Create(MonoOpCodes.Call, setDownloadHandler));

                var setUploadHandler = unityWebRequestType.Methods.First(m => m.Name == "set_uploadHandler");

                il.Append(il.Create(MonoOpCodes.Ldarg_0));
                il.Append(il.Create(MonoOpCodes.Ldarg_S, uploadHandlerParam));
                il.Append(il.Create(MonoOpCodes.Call, setUploadHandler));

                il.Append(il.Create(MonoOpCodes.Ret));

                /*
                .method public hidebysig specialname rtspecialname 
		            instance void .ctor (
			            string url,
			            string 'method',
			            class UnityEngine.Networking.DownloadHandler downloadHandler,
			            class UnityEngine.Networking.UploadHandler uploadHandler
		            ) cil managed 
	            {
		            // Header Size: 1 byte
		            // Code Size: 60 (0x3C) bytes
		            .maxstack 8


		            // {

		            /* 0x000018B9 02           //
                    IL_0000: ldarg.0
		            /* 0x000018BA 282300000A   // IL_0001: call instance void [mscorlib] System.Object::.ctor()
                    /* 0x000018BF 00           // IL_0006: nop
                    /* 0x000018C0 00           // IL_0007: nop

                    //     this.m_Ptr = UnityWebRequest.Create();

                    /* 0x000018C1 02           // IL_0008: ldarg.0
		            /* 0x000018C2 2855000006   // IL_0009: call native int UnityEngine.Networking.UnityWebRequest::Create()
                    /* 0x000018C7 7D19000004   //
                                                  IL_000E: stfld native int UnityEngine.Networking.UnityWebRequest::m_Ptr

                    //     this.InternalSetDefaults();

                    /* 0x000018CC 02           // IL_0013: ldarg.0
                    /* 0x000018CD 2858000006   // IL_0014: call instance void UnityEngine.Networking.UnityWebRequest::InternalSetDefaults()
                    /* 0x000018D2 00           // IL_0019: nop

                    //     this.url = url;

                    /* 0x000018D3 02           // IL_001A: ldarg.0
                    /* 0x000018D4 03           // IL_001B: ldarg.1
                    /* 0x000018D5 2876000006   // IL_001C: call instance void UnityEngine.Networking.UnityWebRequest::set_url(string)
                    /* 0x000018DA 00           // IL_0021: nop

                    //     this.method = method;

                    /* 0x000018DB 02           // IL_0022: ldarg.0
                    /* 0x000018DC 04           // IL_0023: ldarg.2
                    /* 0x000018DD 286E000006   // IL_0024: call instance void UnityEngine.Networking.UnityWebRequest::set_method(string)
                    /* 0x000018E2 00           // IL_0029: nop

                    //     this.downloadHandler = downloadHandler;

                    /* 0x000018E3 02           // IL_002A: ldarg.0
                    /* 0x000018E4 05           // IL_002B: ldarg.3
                    /* 0x000018E5 289C000006   // IL_002C: call instance void UnityEngine.Networking.UnityWebRequest::set_downloadHandler(class UnityEngine.Networking.DownloadHandler)
		            /* 0x000018EA 00           // IL_0031: nop

                    //     this.uploadHandler = uploadHandler;

                    /* 0x000018EB 02           // IL_0032: ldarg.0
		            /* 0x000018EC 0E04         // IL_0033: ldarg.s uploadHandler
                    /* 0x000018EE 2899000006   //
                                                  IL_0035: call instance void UnityEngine.Networking.UnityWebRequest::set_uploadHandler(class UnityEngine.Networking.UploadHandler)
		            /* 0x000018F3 00           // IL_003A: nop

                    // }

                    /* 0x000018F4 2A           // IL_003B: ret
                } // end of method UnityWebRequest::.ctor
                 */

                unityWebRequestType.Methods.Add(ctor);
                Log.LogInfo("Injected UnityWebRequest(string, string, DownloadHandler, UploadHandler)");
            }
        }



        [HarmonyPatch(typeof(IL2CPPDetourMethodPatcher), "Init")]
        [HarmonyTranspiler]
        internal static IEnumerable<CodeInstruction> TranspileIL2CPPDetourMethodPatcherInit(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codes = [.. instructions];

            bool injected = false;

            for (int i = 0; i < codes.Count; i++)
            {
                CodeInstruction code = codes[i];
                yield return code;

                // Look for: stloc.s (Exception ex)
                if (injected || code.opcode != SystemOpCodes.Stloc_S || code.operand is not LocalBuilder local || local.LocalIndex != 5 || local.LocalType != typeof(Exception))
                    continue;

                // Inject after storing ex
                yield return new CodeInstruction(SystemOpCodes.Ldloc_S, local); // load ex
                yield return new CodeInstruction(SystemOpCodes.Ldarg_0);        // load this
                yield return CodeInstruction.Call(typeof(DetourFailures), nameof(DetourFailures.Record));

                Instance.Log.LogInfo("Transpiled DetourFailures.Record after IL2CPPDetourMethodPatcher.Init's catch(Exception ex).");
                injected = true;
            }

            if (!injected)
                Instance.Log.LogWarning("Failed to transpile DetourFailures.Record after IL2CPPDetourMethodPatcher.Init's catch(Exception ex)!");
        }
    }
}