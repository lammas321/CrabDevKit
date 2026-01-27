using System;
using System.Collections.Generic;
using System.IO;
using UnhollowerBaseLib;
using UnityEngine;

namespace CrabDevKit.Utilities
{
    // The stub for the AssetBundle class is missing a constructor, resulting in errors when using any method to load an asset bundle, this class gets around that via IntPtr's.

    // Most of the functionality for managing asset bundles was stripped from the game, as the game has no need for asset bundles normally, leading to the game only allowing one asset bundle to be loaded at any given time.
    // This class has functionality to handle multiple asset bundles being loaded at once, by dynamically unloading and loading asset bundles behind the scenes, maintaining that only one is ever loaded.
    // For this reason, you CANNOT do anything asynchronously:
    // - Because of only allowing one bundle to be loaded at any given time, having async means multiple bundles *could* be loaded at once, leading to issues.
    // - Attempting to load multiple bundles at once via coroutines and async methods will just lead to bundles repeatedly being loaded and unloaded as I have to switch the currently loaded bundle constantly, just leading to worse user experience.

    // Streams are also just weird in Il2Cpp from last I tried making them work, so I just ignored them here.

    [Obsolete("CrabDevKit.Utilities.AssetBundlePtr will be removed in the future! A way to properly fix Asset Bundles was found, making this obsolete.")]
    public sealed class AssetBundlePtr : IDisposable
    {
        internal IntPtr bundlePtr;
        private bool _disposed;

        internal AssetBundlePtr(IntPtr intPtr)
            => bundlePtr = intPtr;

        ~AssetBundlePtr()
            => Unload(true);

        public void Dispose()
            => Unload(true);


        public static AssetBundlePtr LoadFromFile(string path, uint crc = 0u, ulong offset = 0ul)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path), "The asset bundle file path cannot be null.");

            if (!File.Exists(path))
                throw new FileNotFoundException("The asset bundle file path does not point to a file that exists.", path);

            if (offset > long.MaxValue)
                throw new ArgumentOutOfRangeException(nameof(offset), "Offset is greater than long.MaxValue. (Why?)");

            using FileStream stream = new(path, FileMode.Open, FileAccess.Read, FileShare.Read);

            if ((long)offset >= stream.Length)
                throw new ArgumentOutOfRangeException(nameof(offset), "Offset is beyond end of file.");

            stream.Seek((long)offset, SeekOrigin.Begin);

            long remaining = stream.Length - (long)offset;
            byte[] buffer = new byte[remaining];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);

            if (bytesRead != remaining)
                throw new IOException($"Expected {remaining} bytes, but read {bytesRead}.");

            return LoadFromMemory(buffer, crc);
        }

        public static AssetBundlePtr LoadFromMemory(byte[] binary, uint crc = 0u)
            => AssetBundleManager.LoadBundle(binary, crc);


        public bool Contains(string name)
        {
            if (_disposed)
                return false;

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name), "The input asset name cannot be null or empty.");

            AssetBundleManager.MakeCurrentBundle(this);

            return AssetBundle.ContainsDelegateField(bundlePtr, IL2CPP.ManagedStringToIl2Cpp(name));
        }

        public string[] GetAllAssetNames()
        {
            if (_disposed)
                return null;

            AssetBundleManager.MakeCurrentBundle(this);

            IntPtr intPtr = AssetBundle.GetAllAssetNamesDelegateField(bundlePtr);
            return intPtr == IntPtr.Zero ? null : [.. new Il2CppStringArray(intPtr)];
        }

        public string[] GetAllScenePaths()
        {
            if (_disposed)
                return null;

            AssetBundleManager.MakeCurrentBundle(this);

            IntPtr intPtr = AssetBundle.GetAllScenePathsDelegateField(bundlePtr);
            return intPtr == IntPtr.Zero ? null : [.. new Il2CppStringArray(intPtr)];
        }

        public void Unload(bool unloadAllLoadedObjects)
        {
            if (_disposed)
                return;

            AssetBundleManager.MakeCurrentBundle(this);

            AssetBundleManager.DisposeCurrentBundle(unloadAllLoadedObjects);
            GC.SuppressFinalize(this);
            _disposed = true;
        }


        public UnityEngine.Object[] LoadAllAssets(Type type)
        {
            if (_disposed)
                return null;

            if (type == null)
                throw new ArgumentNullException(nameof(type), "The input type cannot be null.");

            AssetBundleManager.MakeCurrentBundle(this);

            Il2CppSystem.Type il2CppType = UnhollowerRuntimeLib.Il2CppType.From(type);
            IntPtr intPtr = AssetBundle.LoadAssetWithSubAssets_InternalDelegateField(bundlePtr, IL2CPP.ManagedStringToIl2Cpp(string.Empty), IL2CPP.Il2CppObjectBaseToPtr(il2CppType));
            return intPtr == IntPtr.Zero ? null : [.. new Il2CppReferenceArray<UnityEngine.Object>(intPtr)];
        }

        public UnityEngine.Object[] LoadAllAssets<T>() where T : UnityEngine.Object
            => LoadAllAssets(typeof(T));
        

        public UnityEngine.Object LoadAsset(string name, Type type)
        {
            if (_disposed)
                return null;

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name), "The input asset name cannot be null or empty.");

            if (type == null)
                throw new ArgumentNullException(nameof(type), "The input type cannot be null.");

            AssetBundleManager.MakeCurrentBundle(this);

            Il2CppSystem.Type il2CppType = UnhollowerRuntimeLib.Il2CppType.From(type);
            IntPtr intPtr = AssetBundle.LoadAsset_InternalDelegateField(bundlePtr, IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(il2CppType));
            return intPtr == IntPtr.Zero ? null : new UnityEngine.Object(intPtr);
        }

        public UnityEngine.Object LoadAsset<T>(string name) where T : UnityEngine.Object
            => LoadAsset(name, typeof(T));
    }



    internal static class AssetBundleManager
    {
        internal static Dictionary<AssetBundlePtr, (Il2CppStructArray<byte>, uint)> managedBundles = [];

        internal static AssetBundlePtr currentBundle;


        internal static AssetBundlePtr LoadBundle(byte[] binary, uint crc)
        {
            MakeCurrentBundle(null);

            Il2CppStructArray<byte> il2CppBinary = new(binary);
            IntPtr intPtr = AssetBundle.LoadFromMemory_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(il2CppBinary), crc);
            if (intPtr == IntPtr.Zero)
                throw new NullReferenceException("Failed to load the bundle. The bundle may not be valid, idk ask Unity lol.");

            currentBundle = new(intPtr);
            managedBundles.Add(currentBundle, (il2CppBinary, crc));

            return currentBundle;
        }

        internal static void MakeCurrentBundle(AssetBundlePtr bundle)
        {
            if (bundle == currentBundle)
                return;

            if (currentBundle != null)
                UnloadCurrentBundle();

            if (bundle == null)
                return;

            IntPtr intPtr = AssetBundle.LoadFromMemory_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(managedBundles[bundle].Item1), managedBundles[bundle].Item2);
            if (intPtr == IntPtr.Zero)
                throw new NullReferenceException("Failed to make bundle the current bundle, odd. It didn't fail previously, so it should be valid, but maybe something went wrong with unloading the previous bundle.");

            bundle.bundlePtr = intPtr;
            currentBundle = bundle;
        }


        internal static void DisposeCurrentBundle(bool unloadAllLoadedObjects = false)
        {
            managedBundles.Remove(currentBundle);
            UnloadCurrentBundle(unloadAllLoadedObjects);
        }

        internal static void UnloadCurrentBundle(bool unloadAllLoadedObjects = false)
        {
            AssetBundle.UnloadDelegateField(currentBundle.bundlePtr, unloadAllLoadedObjects);
            currentBundle.bundlePtr = IntPtr.Zero;
            currentBundle = null;
        }
    }
}