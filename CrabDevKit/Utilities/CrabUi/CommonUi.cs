using System.Collections.Generic;
using TMPro;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CrabDevKit.Utilities.CrabUi
{
    public static class CommonUi
    {
        public static Dictionary<string, TMP_FontAsset> Fonts { get; private set; } = [];
        
        public static TMP_FontAsset RobotoBoldFont
            => Fonts.TryGetValue("Roboto-Bold SDF", out TMP_FontAsset font) ? font : null;

        public static TMP_FontAsset RobotoBoldUnderlayFont
            => Fonts.TryGetValue("Roboto-Bold SDF_UNDERLAY", out TMP_FontAsset font) ? font : null;
        

        public static Dictionary<string, Texture> Textures { get; private set; } = [];

        public static Texture Arrow
            => Textures.TryGetValue("Arrow", out Texture texture) ? texture : null;
        
        public static Texture Circle
            => Textures.TryGetValue("Circle", out Texture texture) ? texture : null;
        
        public static Texture HollowCircle
            => Textures.TryGetValue("HollowCircle", out Texture texture) ? texture : null;

        public static Texture GradientBottLong
            => Textures.TryGetValue("GradientBottLong", out Texture texture) ? texture : null;


        internal static void Init()
        {
            SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;
        }

        private static void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
        {
            if (scene.name != "Menu" || loadSceneMode != (LoadSceneMode)2) // Undefined LoadSceneMode of 2, guessing it's exclusive to the first scene to be loaded
                return;

            SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

            foreach (var obj in Object.FindObjectsOfType(Il2CppType.Of<TextMeshProUGUI>(), includeInactive: true))
            {
                var tmp = new TextMeshProUGUI(obj.Pointer);
                if (tmp.font != null)
                    Fonts[tmp.font.name] = tmp.font;
            }

            foreach (var obj in Object.FindObjectsOfType(Il2CppType.Of<RawImage>(), includeInactive: true))
            {
                var img = new RawImage(obj.Pointer);
                if (img.texture != null)
                    Textures[img.texture.name] = img.texture;
            }
        }
    }
}