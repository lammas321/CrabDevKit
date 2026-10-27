using CrabDevKit.Intermediary;
using HarmonyLib;
using System.Collections.Generic;
using TMPro;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*

TODO

Textboxes

Move SceneInit to an on initial scene loaded callback instead of called it on Settings.Start (this is never called if settings is never opened!!)

GetSetting

CreateMenu
CreateCategory

Thorough testing

*/

namespace CrabDevKit.Utilities
{
    public static class CrabUi
    {
        public static GameObject SettingsMenu { get; private set; }

        public static GameObject GameplaySettingsContent { get; private set; }
        public static GameObject ControlsSettingsContent { get; private set; }
        public static GameObject GraphicsSettingsContent { get; private set; }
        public static GameObject VideoSettingsContent { get; private set; }
        public static GameObject AudioSettingsContent { get; private set; }

        public static Dictionary<string, TMP_FontAsset> Fonts { get; private set; } = [];
        public static Dictionary<string, Texture> Textures { get; private set; } = [];
        public static Dictionary<string, Sprite> Sprites { get; private set; } = [];

        public static TMP_FontAsset RobotoBoldFont
            => Fonts.TryGetValue("Roboto-Bold SDF", out TMP_FontAsset font) ? font : throw new System.InvalidOperationException();
        
        public static TMP_FontAsset RobotoBoldUnderlayFont
            => Fonts.TryGetValue("Roboto-Bold SDF_UNDERLAY", out TMP_FontAsset font) ? font : throw new System.InvalidOperationException();

        public static Texture Arrow
            => Textures.TryGetValue("Arrow", out Texture texture) ? texture : throw new System.InvalidOperationException();
        public static Texture Circle
            => Textures.TryGetValue("Circle", out Texture texture) ? texture : throw new System.InvalidOperationException();
        public static Texture HollowCircle
            => Textures.TryGetValue("HollowCircle", out Texture texture) ? texture : throw new System.InvalidOperationException();
        public static Texture GradientBottLong
            => Textures.TryGetValue("GradientBottLong", out Texture texture) ? texture : throw new System.InvalidOperationException();
        public static Texture GradientLeft
            => Textures.TryGetValue("GradientLeft", out Texture texture) ? texture : throw new System.InvalidOperationException();
        
        public static Sprite DropdownArrow
           => Sprites.TryGetValue("DropdownArrow", out Sprite sprite) ? sprite : throw new System.InvalidOperationException();
        public static Sprite UIMask
           => Sprites.TryGetValue("UIMask", out Sprite sprite) ? sprite : throw new System.InvalidOperationException();
        public static Sprite Checkmark
           => Sprites.TryGetValue("Checkmark", out Sprite sprite) ? sprite : throw new System.InvalidOperationException();


        private static bool _sceneInitialized;

        internal static void Init()
        {
            ClassInjector.RegisterTypeInIl2Cpp<CrabToggle>();
            ClassInjector.RegisterTypeInIl2Cpp<CrabSlider>();
            ClassInjector.RegisterTypeInIl2Cpp<CrabScroll>();
            ClassInjector.RegisterTypeInIl2Cpp<CrabKeybind>();
            ClassInjector.RegisterTypeInIl2Cpp<CrabButton>();
            ClassInjector.RegisterTypeInIl2Cpp<CrabDropdown>();

            Harmony harmony = new($"{MyPluginInfo.PLUGIN_NAME}.CrabUi");
            harmony.PatchAll(typeof(Patches));
        }

        internal static void SceneInit()
        {
            if (_sceneInitialized || SceneManager.GetActiveScene().name != "Menu")
                return;

            _sceneInitialized = true;

            foreach (Object obj in Object.FindObjectsOfType(Il2CppType.Of<TextMeshProUGUI>(), includeInactive: true))
            {
                TextMeshProUGUI tmp = new(obj.Pointer);
                if (tmp.font != null)
                    Fonts[tmp.font.name] = tmp.font;
            }

            foreach (Object obj in Object.FindObjectsOfType(Il2CppType.Of<RawImage>(), includeInactive: true))
            {
                RawImage img = new(obj.Pointer);
                if (img.texture != null)
                    Textures[img.texture.name] = img.texture;
            }

            foreach (Object obj in Object.FindObjectsOfType(Il2CppType.Of<Image>(), includeInactive: true))
            {
                Image img = new(obj.Pointer);
                if (img.sprite != null)
                    Sprites[img.sprite.name] = img.sprite;
            }
        }


        public static void GetCategory(GameObject menuGO, string name,
            out GameObject tabGO, out GameObject categoryGO, out GameObject contentGO)
        {
            if (menuGO == null)
                throw new System.Exception("menuGO cannot be null.");

            if (string.IsNullOrEmpty(name))
                throw new System.Exception("name cannot be null or empty.");


            Transform categoryTf = menuGO.transform.Find(name);
            int index = categoryTf.GetSiblingIndex() - 1;

            tabGO = menuGO.transform.GetChild(0).GetChild(0).GetChild(index).gameObject;
            categoryGO = categoryTf.gameObject;
            contentGO = categoryTf.GetChild(0).GetChild(0).gameObject;
        }

        public static GameObject GetSetting(GameObject contentGO)
        {
            throw new System.NotImplementedException();
        }
        

        public static GameObject CreateMenu(string name)
        {
            throw new System.NotImplementedException();
        }

        public static void CreateCategory(GameObject menuGO, string name,
            out GameObject tabGO, out GameObject categoryGO, out GameObject contentGO, int index = int.MaxValue)
        {
            throw new System.NotImplementedException();
        }

        public static GameObject CreateSetting(GameObject contentGO, string name, int index = int.MaxValue,
            Vector2? size = null, Color? backgroundColor = null,
            bool childControlWidth = true, bool childControlHeight = true,
            bool childForceExpandWidth = false, bool childForceExpandHeight = false,
            bool childScaleWidth = false, bool childScaleHeight = false,
            float spacing = 5f, RectOffset padding = null)
        {
            if (contentGO == null)
                throw new System.Exception("contentGO cannot be null.");

            if (string.IsNullOrEmpty(name))
                throw new System.Exception("name cannot be null or empty.");

            size ??= new(0f, 50f);
            backgroundColor ??= new(0f, 0f, 0f, 0.298f);
            padding ??= new()
            {
                left = 15,
                right = 15,
                top = 5,
                bottom = 5
            };


            GameObject settingGO = new(name);
            settingGO.transform.SetParent(contentGO.transform);
            settingGO.transform.SetSiblingIndex(index);
            settingGO.transform.localScale = Vector3.one;

            RectTransform rect = settingGO.AddComponent<RectTransform>();
            rect.sizeDelta = size.Value;

            CanvasRenderer canvas = settingGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = settingGO.AddComponent<RawImage>();
            img.color = backgroundColor.Value;

            HorizontalLayoutGroup horizontal = settingGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlWidth = childControlWidth;
            horizontal.childControlHeight = childControlHeight;
            horizontal.childForceExpandHeight = childForceExpandWidth;
            horizontal.childForceExpandWidth = childForceExpandHeight;
            horizontal.childScaleWidth = childScaleWidth;
            horizontal.childScaleHeight = childScaleHeight;
            horizontal.spacing = spacing;
            horizontal.padding = padding;

            return settingGO;
        }


        public delegate void CrabCallback();

        public static GameObject CreateLabel(GameObject settingGO, string label, int index = int.MaxValue,
            Vector2? size = null, TMP_FontAsset font = null, float fontSize = 40f, Color? textColor = null,
            bool childControlWidth = true, bool childControlHeight = true,
            bool childForceExpandWidth = true, bool childForceExpandHeight = true,
            bool childScaleWidth = false, bool childScaleHeight = false)
        {
            if (settingGO == null)
                throw new System.Exception("settingGO cannot be null.");

            if (string.IsNullOrEmpty(label))
                throw new System.Exception("label cannot be null or empty.");

            size ??= new(0f, 40f);
            font ??= RobotoBoldFont;
            textColor ??= Color.white;


            GameObject labelGO = new(label);
            labelGO.transform.SetParent(settingGO.transform);
            labelGO.transform.SetSiblingIndex(index);
            labelGO.transform.localScale = Vector3.one;

            RectTransform rect = labelGO.AddComponent<RectTransform>();
            rect.sizeDelta = size.Value;

            CanvasRenderer canvas = labelGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = labelGO.AddComponent<RawImage>();
            img.enabled = false;
            img.color = Color.red;

            HorizontalLayoutGroup horizontal = labelGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlWidth = childControlWidth;
            horizontal.childControlHeight = childControlHeight;
            horizontal.childForceExpandHeight = childForceExpandWidth;
            horizontal.childForceExpandWidth = childForceExpandHeight;
            horizontal.childScaleWidth = childScaleWidth;
            horizontal.childScaleHeight = childScaleHeight;
            horizontal.childAlignment = TextAnchor.MiddleLeft;

            GameObject textGO = new("Text (TMP)");
            textGO.transform.SetParent(labelGO.transform);
            textGO.transform.localScale = Vector3.one;

            RectTransform textRect = textGO.AddComponent<RectTransform>();
            textRect.sizeDelta = size.Value;

            CanvasRenderer textCanvas = textGO.AddComponent<CanvasRenderer>();
            textCanvas.cullTransparentMesh = false;

            TextMeshProUGUI text = textGO.AddComponent<TextMeshProUGUI>();
            text.text = label;
            text.font = font;
            text.fontSize = fontSize;
            text.color = textColor.Value;
            text.alignment = TextAlignmentOptions.Left;

            return labelGO;
        }

        public static CrabToggle CreateToggle(GameObject settingGO, string name, int index = int.MaxValue,
            bool initialState = false, float size = 40f, Color? outerColor = null, Color? innerColor = null,
            RectOffset padding = null)
        {
            if (settingGO == null)
                throw new System.Exception("settingGO cannot be null.");

            if (string.IsNullOrEmpty(name))
                throw new System.Exception("name cannot be null or empty.");

            outerColor ??= Color.white;
            innerColor ??= Color.white;
            padding ??= new()
            {
                left = 0,
                right = 10,
                top = 0,
                bottom = 0
            };


            GameObject toggleGO = toggleGO = new(name);
            toggleGO.transform.SetParent(settingGO.transform);
            toggleGO.transform.SetSiblingIndex(index);
            toggleGO.transform.localScale = Vector3.one;

            RectTransform rect = toggleGO.AddComponent<RectTransform>();
            rect.sizeDelta = Vector2.one * size;

            CanvasRenderer canvas = toggleGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = toggleGO.AddComponent<RawImage>();
            img.enabled = false;
            img.color = Color.red;

            HorizontalLayoutGroup horizontal = toggleGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlHeight = false;
            horizontal.childControlWidth = false;
            horizontal.childForceExpandHeight = true;
            horizontal.childForceExpandWidth = true;
            horizontal.childAlignment = TextAnchor.MiddleRight;
            horizontal.padding = padding;

            GameObject buttonGO = new("Button");
            buttonGO.transform.SetParent(toggleGO.transform);
            buttonGO.transform.localScale = Vector3.one;

            RectTransform buttonRect = buttonGO.AddComponent<RectTransform>();
            buttonRect.sizeDelta = Vector2.one * size;

            CanvasRenderer buttonCanvas = buttonGO.AddComponent<CanvasRenderer>();
            buttonCanvas.cullTransparentMesh = false;

            CrabToggle crabToggle = buttonGO.AddComponent<CrabToggle>();

            Button button = buttonGO.AddComponent<Button>();
            button.onClick.AddListener(
                crabToggle,
                crabToggle.GetIl2CppType().GetMethod(nameof(CrabToggle.Pressed))
            );

            RawImage buttonImg = buttonGO.AddComponent<RawImage>();
            buttonImg.texture = HollowCircle;
            buttonImg.color = outerColor.Value;

            buttonGO.AddComponent<ButtonSfx>();

            GameObject innerGO = new("Toggle");
            innerGO.transform.SetParent(buttonGO.transform);
            innerGO.transform.localScale = Vector3.one * 0.5f;
            innerGO.SetActive(initialState);

            RectTransform innerRect = innerGO.AddComponent<RectTransform>();
            innerRect.sizeDelta = Vector2.zero;
            innerRect.anchorMin = Vector2.zero;
            innerRect.anchorMax = Vector2.one;

            CanvasRenderer innerCanvas = innerGO.AddComponent<CanvasRenderer>();
            innerCanvas.cullTransparentMesh = false;

            RawImage innerImg = innerGO.AddComponent<RawImage>();
            innerImg.texture = Circle;
            innerImg.color = innerColor.Value;

            crabToggle.state = initialState;
            crabToggle.innerGO = innerGO;

            return crabToggle;
        }

        public sealed class CrabToggle : MonoBehaviour
        {
            internal bool state;
            internal GameObject innerGO;
            [HideFromIl2Cpp] public event CrabCallback Callback;

            [HideFromIl2Cpp] public bool State
            {
                [HideFromIl2Cpp] get => state;
                [HideFromIl2Cpp] set
                {
                    if (state == value)
                        return;

                    state = value;
                    innerGO.SetActive(state);
                    Callback?.Invoke();
                }
            }

            public void Pressed()
            {
                State = !State;
            }
        }

        public static CrabSlider CreateSlider(GameObject settingGO, string name, int index = int.MaxValue,
            float minState = 0f, float maxState = 10f, float initialState = 5f, bool wholeNumbers = true,
            Vector2? size = null, float fillHeight = 10f, float handleWidth = 15f, Vector2? valueSize = null,
            TMP_FontAsset font = null, Color? textColor = null, Color? backgroundColor = null,
            Color? fillColor = null, Color? valueTextBackgroundColor = null)
        {
            if (settingGO == null)
                throw new System.Exception("settingGO cannot be null.");

            if (string.IsNullOrEmpty(name))
                throw new System.Exception("name cannot be null or empty.");

            if (minState > maxState)
                throw new System.Exception("minState should be less than or equal to maxState.");

            initialState = Mathf.Clamp(initialState, minState, maxState);
            size ??= new(230f, 40f);
            valueSize ??= new(90f, 40f);
            font ??= RobotoBoldFont;
            textColor ??= Color.white;
            backgroundColor ??= new(0f, 0f, 0f, 0.5804f);
            fillColor ??= new(0.2235f, 0.2745f, 0.8f);
            valueTextBackgroundColor ??= new(0f, 0f, 0f, 0.502f);


            GameObject sliderGO = new(name);
            sliderGO.transform.SetParent(settingGO.transform);
            sliderGO.transform.SetSiblingIndex(index);
            sliderGO.transform.localScale = Vector3.one;

            RectTransform rect = sliderGO.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(size.Value.x + valueSize.Value.x + 25f, size.Value.y);

            CanvasRenderer canvas = sliderGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = sliderGO.AddComponent<RawImage>();
            img.enabled = false;
            img.color = Color.red;

            HorizontalLayoutGroup horizontal = sliderGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlHeight = false;
            horizontal.childControlWidth = false;
            horizontal.childForceExpandHeight = false;
            horizontal.childForceExpandWidth = false;
            horizontal.spacing = 25f;
            horizontal.childAlignment = TextAnchor.MiddleCenter;

            GameObject innerGO = new("Slider");
            innerGO.transform.SetParent(sliderGO.transform);
            innerGO.transform.localScale = Vector3.one;

            RectTransform innerRect = innerGO.AddComponent<RectTransform>();
            innerRect.sizeDelta = size.Value;

            CrabSlider crabSlider = innerGO.AddComponent<CrabSlider>();

            Slider slider = innerGO.AddComponent<Slider>();
            slider.wholeNumbers = wholeNumbers;
            slider.minValue = minState;
            slider.maxValue = maxState;
            slider.value = initialState;
            slider.onValueChanged.AddListener(
                crabSlider,
                crabSlider.GetIl2CppType().GetMethod(nameof(CrabSlider.Changed))
            );

            GameObject backgroundGO = new("Background");
            backgroundGO.transform.SetParent(innerGO.transform);
            backgroundGO.transform.localScale = Vector3.one;

            RectTransform backgroundRect = backgroundGO.AddComponent<RectTransform>();
            backgroundRect.anchorMax = new Vector2(0.9787f, 0.75f);
            backgroundRect.anchorMin = new Vector2(0.0213f, 0.25f);
            backgroundRect.sizeDelta = new Vector2(0f, -fillHeight);

            CanvasRenderer backgroundCanvas = backgroundGO.AddComponent<CanvasRenderer>();
            backgroundCanvas.cullTransparentMesh = false;

            Image backgroundImg = backgroundGO.AddComponent<Image>();
            backgroundImg.color = backgroundColor.Value;

            GameObject fillAreaGO = new("Fill Area");
            fillAreaGO.transform.SetParent(innerGO.transform);
            fillAreaGO.transform.localScale = Vector3.one;

            RectTransform fillAreaRect = fillAreaGO.AddComponent<RectTransform>();
            fillAreaRect.anchorMax = new Vector2(0.9787f, 0.75f);
            fillAreaRect.anchorMin = new Vector2(0.0213f, 0.25f);
            fillAreaRect.sizeDelta = new Vector2(0f, -fillHeight);

            GameObject fillGO = new("Fill");
            fillGO.transform.SetParent(fillAreaGO.transform);
            fillGO.transform.localScale = Vector3.one;

            RectTransform fillRect = fillGO.AddComponent<RectTransform>();
            fillRect.anchorMax = new Vector2(1f, 1f);
            fillRect.anchorMin = new Vector2(0f, 0f);
            fillRect.sizeDelta = new Vector2(0f, 0f);
            fillRect.localPosition = Vector3.zero;

            CanvasRenderer fillCanvas = fillGO.AddComponent<CanvasRenderer>();
            fillCanvas.cullTransparentMesh = false;

            Image fillImg = fillGO.AddComponent<Image>();
            fillImg.color = fillColor.Value;

            slider.fillRect = fillRect;

            GameObject slideAreaGO = new("Handle Slide Area");
            slideAreaGO.transform.SetParent(innerGO.transform);
            slideAreaGO.transform.localScale = Vector3.one;

            RectTransform slideAreaRect = slideAreaGO.AddComponent<RectTransform>();
            slideAreaRect.anchorMax = new Vector2(1f, 1f);
            slideAreaRect.anchorMin = new Vector2(0f, 0f);
            slideAreaRect.sizeDelta = new Vector2(-20f, 0f);

            GameObject handleGO = new("Handle");
            handleGO.transform.SetParent(slideAreaGO.transform);
            handleGO.transform.localScale = Vector3.one;

            RectTransform handleRect = handleGO.AddComponent<RectTransform>();
            handleRect.anchorMax = new Vector2(1f, 1f);
            handleRect.anchorMin = new Vector2(1f, 0f);
            handleRect.sizeDelta = new Vector2(handleWidth, 0f);

            CanvasRenderer handleCanvas = handleGO.AddComponent<CanvasRenderer>();
            handleCanvas.cullTransparentMesh = false;

            handleGO.AddComponent<Image>();

            handleGO.AddComponent<ButtonSfx>();

            slider.handleRect = handleRect;

            GameObject valueTextGO = new("Value Text");
            valueTextGO.transform.SetParent(sliderGO.transform);
            valueTextGO.transform.localScale = Vector3.one;

            RectTransform valueTextRect = valueTextGO.AddComponent<RectTransform>();
            valueTextRect.sizeDelta = valueSize.Value;

            CanvasRenderer valueTextCanvas = valueTextGO.AddComponent<CanvasRenderer>();
            valueTextCanvas.cullTransparentMesh = false;

            RawImage valueTextImage = valueTextGO.AddComponent<RawImage>();
            valueTextImage.color = valueTextBackgroundColor.Value;

            GameObject textGO = new("Text (TMP)");
            textGO.transform.SetParent(valueTextGO.transform);
            textGO.transform.localScale = Vector3.one;

            RectTransform textRect = textGO.AddComponent<RectTransform>();
            textRect.sizeDelta = valueSize.Value;

            CanvasRenderer textCanvas = textGO.AddComponent<CanvasRenderer>();
            textCanvas.cullTransparentMesh = false;

            TextMeshProUGUI text = textGO.AddComponent<TextMeshProUGUI>();
            text.text = initialState.ToString();
            text.font = font;
            text.color = textColor.Value;
            text.alignment = TextAlignmentOptions.Center;

            crabSlider.slider = slider;
            crabSlider.text = text;

            return crabSlider;
        }
        
        public sealed class CrabSlider : MonoBehaviour
        {
            internal Slider slider;
            internal TextMeshProUGUI text;
            [HideFromIl2Cpp] public event CrabCallback Callback;

            [HideFromIl2Cpp] public Slider Slider => slider;
            [HideFromIl2Cpp] public TextMeshProUGUI Text => text;

            public void Changed(float state)
            {
                text.text = state.ToString();
                Callback?.Invoke();
            }
        }

        public static CrabScroll CreateScroll(GameObject settingGO, string name, int index = int.MaxValue,
            int initialState = 0, IReadOnlyList<object> options = null, float size = 40f, float textWidth = 300f,
            TMP_FontAsset font = null, Color? textColor = null, Color? buttonColor = null)
        {
            if (settingGO == null)
                throw new System.Exception("settingGO cannot be null.");

            if (string.IsNullOrEmpty(name))
                throw new System.Exception("name cannot be null or empty.");

            if (options == null || options.Count == 0)
                throw new System.Exception("options cannot be null or empty.");

            initialState = Mathf.Clamp(initialState, 0, options.Count - 1);
            font ??= RobotoBoldFont;
            textColor ??= Color.white;
            buttonColor ??= Color.white;


            GameObject scrollGO = new(name);
            scrollGO.transform.SetParent(settingGO.transform);
            scrollGO.transform.SetSiblingIndex(index);
            scrollGO.transform.localScale = Vector3.one;

            RectTransform rect = scrollGO.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2((size * 2f) + textWidth, size);

            CanvasRenderer canvas = scrollGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = scrollGO.AddComponent<RawImage>();
            img.enabled = false;
            img.color = Color.red;

            HorizontalLayoutGroup horizontal = scrollGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlHeight = false;
            horizontal.childControlWidth = false;
            horizontal.childForceExpandHeight = false;
            horizontal.childForceExpandWidth = false;
            horizontal.childAlignment = TextAnchor.MiddleCenter;

            CrabScroll crabScroll = scrollGO.AddComponent<CrabScroll>();

            GameObject leftGO = new("Left");
            leftGO.transform.SetParent(scrollGO.transform);
            leftGO.transform.localScale = Vector3.one;

            RectTransform leftRect = leftGO.AddComponent<RectTransform>();
            leftRect.sizeDelta = Vector2.one * size;

            CanvasRenderer leftCanvas = leftGO.AddComponent<CanvasRenderer>();
            leftCanvas.cullTransparentMesh = false;

            RawImage leftImage = leftGO.AddComponent<RawImage>();
            leftImage.enabled = false;
            leftImage.color = Color.red;

            GameObject leftButtonGO = new("Button");
            leftButtonGO.transform.SetParent(leftGO.transform);
            leftButtonGO.transform.localScale = new Vector3(-1f, 1f, 1f);

            RectTransform leftButtonRect = leftButtonGO.AddComponent<RectTransform>();
            leftButtonRect.sizeDelta = Vector2.one * size;

            CanvasRenderer leftButtonCanvas = leftButtonGO.AddComponent<CanvasRenderer>();
            leftButtonCanvas.cullTransparentMesh = false;

            Button leftButton = leftButtonGO.AddComponent<Button>();
            leftButton.onClick.AddListener(
                crabScroll,
                crabScroll.GetIl2CppType().GetMethod(nameof(CrabScroll.ScrollLeft))
            );

            leftButtonGO.AddComponent<ButtonSfx>();

            RawImage leftButtonImg = leftButtonGO.AddComponent<RawImage>();
            leftButtonImg.texture = Arrow;
            leftButtonImg.color = buttonColor.Value;
            leftButtonImg.enabled = initialState != 0;

            GameObject valueTextGO = new("Text");
            valueTextGO.transform.SetParent(scrollGO.transform);
            valueTextGO.transform.localScale = Vector3.one;

            RectTransform valueTextRect = valueTextGO.AddComponent<RectTransform>();
            valueTextRect.sizeDelta = new Vector2(textWidth, size);

            CanvasRenderer valueTextCanvas = valueTextGO.AddComponent<CanvasRenderer>();
            valueTextCanvas.cullTransparentMesh = false;

            RawImage valueTextImage = valueTextGO.AddComponent<RawImage>();
            valueTextImage.enabled = false;
            valueTextImage.color = Color.red;

            GameObject textGO = new("Text (TMP)");
            textGO.transform.SetParent(valueTextGO.transform);
            textGO.transform.localScale = Vector3.one;

            RectTransform textRect = textGO.AddComponent<RectTransform>();
            textRect.sizeDelta = new Vector2(textWidth, size);

            CanvasRenderer textCanvas = textGO.AddComponent<CanvasRenderer>();
            textCanvas.cullTransparentMesh = false;

            TextMeshProUGUI text = textGO.AddComponent<TextMeshProUGUI>();
            text.text = options[initialState].ToString();
            text.font = font;
            text.color = textColor.Value;
            text.alignment = TextAlignmentOptions.Center;

            GameObject rightGO = new("Right");
            rightGO.transform.SetParent(scrollGO.transform);
            rightGO.transform.localScale = Vector3.one;

            RectTransform rightRect = rightGO.AddComponent<RectTransform>();
            rightRect.sizeDelta = Vector2.one * size;

            CanvasRenderer rightCanvas = rightGO.AddComponent<CanvasRenderer>();
            rightCanvas.cullTransparentMesh = false;

            RawImage rightImage = rightGO.AddComponent<RawImage>();
            rightImage.enabled = false;
            rightImage.color = Color.red;

            GameObject rightButtonGO = new("Button");
            rightButtonGO.transform.SetParent(rightGO.transform);
            rightButtonGO.transform.localScale = Vector3.one;

            RectTransform rightButtonRect = rightButtonGO.AddComponent<RectTransform>();
            rightButtonRect.sizeDelta = Vector2.one * size;

            CanvasRenderer rightButtonCanvas = rightButtonGO.AddComponent<CanvasRenderer>();
            rightButtonCanvas.cullTransparentMesh = false;

            Button rightButton = rightButtonGO.AddComponent<Button>();
            rightButton.onClick.AddListener(
                crabScroll,
                crabScroll.GetIl2CppType().GetMethod(nameof(CrabScroll.ScrollRight))
            );

            rightButtonGO.AddComponent<ButtonSfx>();

            RawImage rightButtonImg = rightButtonGO.AddComponent<RawImage>();
            rightButtonImg.texture = Arrow;
            rightButtonImg.color = buttonColor.Value;
            rightButtonImg.enabled = initialState != options.Count - 1;

            crabScroll.text = text;
            crabScroll.leftButtonImg = leftButtonImg;
            crabScroll.rightButtonImg = rightButtonImg;

            crabScroll.state = initialState;
            crabScroll.options = [.. options];

            return crabScroll;
        }

        public sealed class CrabScroll : MonoBehaviour
        {
            internal int state;
            internal object[] options;
            internal TextMeshProUGUI text;
            internal RawImage leftButtonImg;
            internal RawImage rightButtonImg;
            [HideFromIl2Cpp] public event CrabCallback Callback;

            [HideFromIl2Cpp]
            public int State
            {
                [HideFromIl2Cpp]
                get => state;
                [HideFromIl2Cpp]
                set
                {
                    value = Mathf.Clamp(value, 0, options.Length - 1);
                    if (state == value)
                        return;

                    state = value;
                    text.text = options[state].ToString();
                    leftButtonImg.enabled = state != 0;
                    rightButtonImg.enabled = state != options.Length - 1;
                    Callback?.Invoke();
                }
            }

            [HideFromIl2Cpp]
            public IReadOnlyList<object> Options
            {
                [HideFromIl2Cpp]
                get => options;
                [HideFromIl2Cpp]
                set
                {
                    if (value == null || value.Count < 0)
                        return;

                    options = [.. value];
                    state = Mathf.Clamp(state, 0, options.Length - 1);
                    text.text = options[state].ToString();
                    leftButtonImg.enabled = state != 0;
                    rightButtonImg.enabled = state != options.Length - 1;
                    Callback?.Invoke();
                }
            }

            public void ScrollLeft()
            {
                State--;
            }

            public void ScrollRight()
            {
                State++;
            }
        }

        public static CrabKeybind CreateKeybind(GameObject settingGO, string name, int index = int.MaxValue,
            KeyCode initialKey = KeyCode.None, Vector2? size = null, TMP_FontAsset font = null,
            Color? textColor = null, ColorBlock? buttonColors = null)
        {
            if (settingGO == null)
                throw new System.Exception("settingGO cannot be null.");

            if (string.IsNullOrEmpty(name))
                throw new System.Exception("name cannot be null or empty.");

            if (!System.Enum.IsDefined(typeof(KeyCode), initialKey) && (int)initialKey != -1 && (int)initialKey != -2)
                throw new System.Exception("initialKey cannot be invalid.");

            size ??= new(300f, 40f);
            font ??= RobotoBoldFont;
            textColor ??= Color.white;
            buttonColors ??= new()
            {
                normalColor = new(0f, 0f, 0f, 0.502f),
                highlightedColor = new(0.7075f, 0.7075f, 0.7075f, 0.502f),
                pressedColor = new(0f, 0f, 0f, 1f),
                selectedColor = new(0f, 0f, 0f, 0.502f),
                disabledColor = new(0.7843f, 0.7843f, 0.7843f, 0.502f),
                colorMultiplier = 1f,
                fadeDuration = 0.1f
            };


            GameObject keybindGO = new(name);
            keybindGO.transform.SetParent(settingGO.transform);
            keybindGO.transform.SetSiblingIndex(index);
            keybindGO.transform.localScale = Vector3.one;

            RectTransform rect = keybindGO.AddComponent<RectTransform>();
            rect.sizeDelta = size.Value;

            CanvasRenderer canvas = keybindGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = keybindGO.AddComponent<RawImage>();
            img.enabled = false;
            img.color = Color.red;

            HorizontalLayoutGroup horizontal = keybindGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlHeight = false;
            horizontal.childControlWidth = false;
            horizontal.childForceExpandHeight = false;
            horizontal.childForceExpandWidth = false;
            horizontal.childAlignment = TextAnchor.MiddleCenter;

            CrabKeybind crabKeybind = keybindGO.AddComponent<CrabKeybind>();
            crabKeybind.setting = keybindGO.AddComponent<ControlSetting>();

            GameObject buttonGO = new("Button");
            buttonGO.transform.SetParent(keybindGO.transform);
            buttonGO.transform.localScale = Vector3.one;

            RectTransform buttonRect = buttonGO.AddComponent<RectTransform>();
            buttonRect.sizeDelta = size.Value;

            CanvasRenderer buttonCanvas = buttonGO.AddComponent<CanvasRenderer>();
            buttonCanvas.cullTransparentMesh = false;

            buttonGO.AddComponent<RawImage>();

            Button button = buttonGO.AddComponent<Button>();
            button.colors = buttonColors.Value;
            button.onClick.AddListener(
                crabKeybind.setting,
                crabKeybind.setting.GetIl2CppType().GetMethod(nameof(ControlSetting.StartListening))
            );

            buttonGO.AddComponent<ButtonSfx>();

            GameObject textGO = new("Text (TMP)");
            textGO.transform.SetParent(buttonGO.transform);
            textGO.transform.localScale = Vector3.one;

            RectTransform textRect = textGO.AddComponent<RectTransform>();
            textRect.sizeDelta = size.Value;

            CanvasRenderer textCanvas = textGO.AddComponent<CanvasRenderer>();
            textCanvas.cullTransparentMesh = false;

            TextMeshProUGUI text = textGO.AddComponent<TextMeshProUGUI>();
            text.text = crabKeybind.setting.intToKeyCode((int)initialKey);
            text.font = font;
            text.color = textColor.Value;
            text.alignment = TextAlignmentOptions.Center;

            crabKeybind.text = text;

            GameObject fakeGO = new("Fake Text"); // fake text for ControlSetting to use on update
            fakeGO.transform.SetParent(textGO.transform);
            fakeGO.transform.localScale = Vector3.one;
            fakeGO.SetActive(false);

            RectTransform fakeRect = fakeGO.AddComponent<RectTransform>();
            fakeRect.sizeDelta = size.Value;

            crabKeybind.setting.keyText = fakeGO.AddComponent<TextMeshProUGUI>();
            crabKeybind.setting.keyText.enabled = false;

            crabKeybind.setting.set_actionName(name);
            crabKeybind.setting.currentKey = (int)initialKey;

            crabKeybind.setting.m_OnClick.AddListener(
                crabKeybind,
                crabKeybind.GetIl2CppType().GetMethod(nameof(CrabKeybind.KeybindUpdated))
            );

            return crabKeybind;
        }

        public sealed class CrabKeybind : MonoBehaviour
        {
            internal ControlSetting setting;
            internal TextMeshProUGUI text;
            [HideFromIl2Cpp] public event CrabCallback Callback;
            
            [HideFromIl2Cpp]
            public KeyCode Key
            {
                [HideFromIl2Cpp]
                get => (KeyCode)setting.currentKey;
                [HideFromIl2Cpp]
                set
                {
                    if (setting.currentKey == (int)value)
                        return;

                    if (!System.Enum.IsDefined(typeof(KeyCode), value) && (int)value != -1 && (int)value != -2)
                        return;

                    setting.currentKey = (int)value;
                    text.text = setting.intToKeyCode(setting.currentKey);
                    Callback?.Invoke();
                }
            }

            public void KeybindUpdated()
            {
                text.text = setting.intToKeyCode(setting.currentKey);
                Callback?.Invoke();
            }
        }

        public static CrabButton CreateButton(GameObject settingGO, string name, int index = int.MaxValue,
            float height = 40f, Vector2? size = null, float glossWidth = 20f, float glossHeight = 12f, RectOffset padding = null,
            Color? buttonColor = null, ColorBlock? buttonColors = null, TMP_FontAsset font = null, Color? textColor = null)
        {
            if (settingGO == null)
                throw new System.Exception("settingGO cannot be null.");

            if (string.IsNullOrEmpty(name))
                throw new System.Exception("name cannot be null or empty.");

            size ??= new(151.92f, 39.3f);
            padding ??= new()
            {
                left = 0,
                right = 10,
                top = 0,
                bottom = 0
            };
            buttonColor ??= new(1f, 0f, 0.0285f, 1f);
            buttonColors ??= new()
            {
                normalColor = Color.white,
                highlightedColor = new(0.7453f, 0.7453f, 0.7453f, 1f),
                pressedColor = new(0.5f, 0.5f, 0.5f, 1f),
                selectedColor = new(0.9608f, 0.9608f, 0.9608f, 1f),
                disabledColor = new(0.7843f, 0.7843f, 0.7843f, 0.502f),
                colorMultiplier = 1f,
                fadeDuration = 0.1f
            };
            font ??= RobotoBoldUnderlayFont;
            textColor ??= Color.white;


            GameObject buttonGO = new(name);
            buttonGO.transform.SetParent(settingGO.transform);
            buttonGO.transform.SetSiblingIndex(index);
            buttonGO.transform.localScale = Vector3.one;

            RectTransform rect = buttonGO.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(size.Value.x, height);

            CanvasRenderer canvas = buttonGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = buttonGO.AddComponent<RawImage>();
            img.enabled = false;
            img.color = Color.red;

            HorizontalLayoutGroup horizontal = buttonGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlHeight = false;
            horizontal.childControlWidth = false;
            horizontal.childAlignment = TextAnchor.MiddleRight;
            horizontal.padding = padding;

            GameObject innerGO = new("UiButtonKids");
            innerGO.transform.SetParent(buttonGO.transform);
            innerGO.transform.localScale = Vector3.one;

            RectTransform innerRect = innerGO.AddComponent<RectTransform>();
            innerRect.anchorMax = new(0f, 1f);
            innerRect.anchorMin = new(0f, 1f);
            innerRect.sizeDelta = size.Value;

            innerGO.AddComponent<CanvasRenderer>();

            Image buttonImg = innerGO.AddComponent<Image>();
            buttonImg.color = buttonColor.Value;

            CrabButton crabButton = innerGO.AddComponent<CrabButton>();

            Button button = innerGO.AddComponent<Button>();
            button.onClick.AddListener(
                crabButton,
                crabButton.GetIl2CppType().GetMethod(nameof(CrabButton.Pressed))
            );
            button.colors = buttonColors.Value;

            innerGO.AddComponent<ButtonSfx>();

            GameObject topGO = new("Top Gloss");
            topGO.transform.SetParent(innerGO.transform);
            topGO.transform.localEulerAngles = new(0f, 0f, 180f);
            topGO.transform.localScale = Vector3.one;

            RectTransform topRect = topGO.AddComponent<RectTransform>();
            topRect.anchoredPosition = Vector2.zero;
            topRect.anchorMax = new(1f, 1f);
            topRect.anchorMin = new(0f, 1f);
            topRect.pivot = new(0.5f, 0f);
            topRect.sizeDelta = new(0f, glossHeight);

            topGO.AddComponent<CanvasRenderer>();

            RawImage topImg = topGO.AddComponent<RawImage>();
            topImg.texture = GradientBottLong;
            topImg.color = new(0f, 0f, 0f, 0.3569f);

            GameObject bottomGO = new("Bottom Gloss");
            bottomGO.transform.SetParent(innerGO.transform);
            bottomGO.transform.localScale = Vector3.one;

            RectTransform bottomRect = bottomGO.AddComponent<RectTransform>();
            bottomRect.anchoredPosition = Vector2.zero;
            bottomRect.anchorMax = new(1f, 0f);
            bottomRect.anchorMin = new(0f, 0f);
            bottomRect.pivot = new(0.5f, 0f);
            bottomRect.sizeDelta = new(0f, glossHeight);

            bottomGO.AddComponent<CanvasRenderer>();

            RawImage bottomImg = bottomGO.AddComponent<RawImage>();
            bottomImg.texture = GradientBottLong;
            bottomImg.color = new(0f, 0f, 0f, 0.3569f);

            GameObject leftGO = new("Left Gloss");
            leftGO.transform.SetParent(innerGO.transform);
            leftGO.transform.localScale = Vector3.one;

            RectTransform leftRect = leftGO.AddComponent<RectTransform>();
            leftRect.anchoredPosition = Vector2.zero;
            leftRect.anchorMax = new(0f, 1f);
            leftRect.anchorMin = new(0f, 0f);
            leftRect.pivot = new(0f, 0.5f);
            leftRect.sizeDelta = new(glossWidth, 0f);

            leftGO.AddComponent<CanvasRenderer>();

            RawImage leftImg = leftGO.AddComponent<RawImage>();
            leftImg.texture = GradientLeft;
            leftImg.color = new(0f, 0f, 0f, 0.3569f);

            GameObject rightGO = new("Right Gloss");
            rightGO.transform.SetParent(innerGO.transform);
            rightGO.transform.localEulerAngles = new(0f, 0f, 180f);
            rightGO.transform.localScale = Vector3.one;

            RectTransform rightRect = rightGO.AddComponent<RectTransform>();
            rightRect.anchoredPosition = Vector2.zero;
            rightRect.anchorMax = new(1f, 1f);
            rightRect.anchorMin = new(1f, 0f);
            rightRect.pivot = new(0f, 0.5f);
            rightRect.sizeDelta = new(glossWidth, 0f);

            rightGO.AddComponent<CanvasRenderer>();

            RawImage rightImg = rightGO.AddComponent<RawImage>();
            rightImg.texture = GradientLeft;
            rightImg.color = new(0f, 0f, 0f, 0.3569f);

            GameObject textGO = new("Text (TMP)");
            textGO.transform.SetParent(innerGO.transform);
            textGO.transform.localScale = Vector3.one;

            RectTransform textRect = textGO.AddComponent<RectTransform>();
            textRect.anchoredPosition = Vector2.zero;

            textGO.AddComponent<CanvasRenderer>();

            TextMeshProUGUI text = textGO.AddComponent<TextMeshProUGUI>();
            text.text = name;
            text.font = font;
            text.fontSize = 28.4f;
            text.fontSizeMax = 40f;
            text.fontSizeMin = 12f;
            text.color = textColor.Value;
            text.alignment = TextAlignmentOptions.Center;

            return crabButton;
        }
        
        public sealed class CrabButton : MonoBehaviour
        {
            [HideFromIl2Cpp] public event CrabCallback Callback;

            public void Pressed()
            {
                Callback?.Invoke();
            }
        }

        public static CrabDropdown CreateDropdown(GameObject settingGO, string name, int index = int.MaxValue,
            int initialState = 0, IReadOnlyList<object> options = null, float width = 300f, float spacing = 10f,
            float applyWidth = 100f, float height = 50f)
        {
            if (settingGO == null)
                throw new System.Exception("settingGO cannot be null.");

            if (string.IsNullOrEmpty(name))
                throw new System.Exception("name cannot be null or empty.");

            if (options == null || options.Count == 0)
                throw new System.Exception("options cannot be null or empty.");

            initialState = Mathf.Clamp(initialState, 0, options.Count - 1);


            GameObject dropdownGO = new(name);
            dropdownGO.transform.SetParent(settingGO.transform);
            dropdownGO.transform.SetSiblingIndex(index);
            dropdownGO.transform.localScale = Vector3.one;

            RectTransform rect = dropdownGO.AddComponent<RectTransform>();
            rect.sizeDelta = new(width + spacing + applyWidth, height);

            CanvasRenderer canvasRenderer = dropdownGO.AddComponent<CanvasRenderer>();
            canvasRenderer.cullTransparentMesh = false;

            RawImage img = dropdownGO.AddComponent<RawImage>();
            img.enabled = false;
            img.color = Color.red;

            HorizontalLayoutGroup horizontal = dropdownGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlHeight = false;
            horizontal.childControlWidth = false;
            horizontal.childForceExpandHeight = false;
            horizontal.childForceExpandWidth = false;
            horizontal.childScaleHeight = false;
            horizontal.childScaleWidth = false;
            horizontal.spacing = spacing;
            horizontal.childAlignment = TextAnchor.MiddleCenter;

            CrabDropdown crabDropdown = dropdownGO.AddComponent<CrabDropdown>();

            GameObject innerGO = new("Dropdown");
            innerGO.transform.SetParent(dropdownGO.transform);
            innerGO.transform.localScale = Vector3.one;

            RectTransform innerRect = innerGO.AddComponent<RectTransform>();
            innerRect.sizeDelta = new(width, height);

            innerGO.AddComponent<CanvasRenderer>();

            Image innerImg = innerGO.AddComponent<Image>();
            innerImg.color = new(0f, 0f, 0f, 0.502f);

            TMP_Dropdown dropdown = innerGO.AddComponent<TMP_Dropdown>();
            dropdown.image = innerImg;
            dropdown.options.EnsureCapacity(options.Count);
            foreach (var option in options)
                dropdown.options.Add(new(option.ToString()));
            dropdown.value = initialState;

            dropdown.onValueChanged.AddListener(
                crabDropdown,
                crabDropdown.GetIl2CppType().GetMethod(nameof(CrabDropdown.OptionSelected))
            );

            crabDropdown.dropdown = dropdown;

            GameObject labelGO = new("Label");
            labelGO.transform.SetParent(innerGO.transform);
            labelGO.transform.localScale = Vector3.one;

            RectTransform labelRect = labelGO.AddComponent<RectTransform>();
            labelRect.anchorMax = Vector2.one;
            labelRect.anchorMin = Vector2.zero;
            labelRect.sizeDelta = new(-35f, -13f);
            labelRect.anchoredPosition = new(-7.5f, -0.5f);

            labelGO.AddComponent<CanvasRenderer>();

            TextMeshProUGUI labelText = labelGO.AddComponent<TextMeshProUGUI>();
            labelText.font = RobotoBoldFont;
            labelText.fontSize = 20f;
            labelText.fontSizeMin = 18f;
            labelText.fontSizeMax = 72f;
            labelText.alignment = TextAlignmentOptions.Left;
            labelText.enableKerning = true;
            labelText.enableWordWrapping = true;
            labelText.overflowMode = TextOverflowModes.Ellipsis;

            dropdown.captionText = labelText;

            GameObject arrowGO = new("Arrow");
            arrowGO.transform.SetParent(innerGO.transform);
            arrowGO.transform.localScale = Vector3.one;

            RectTransform arrowRect = arrowGO.AddComponent<RectTransform>();
            arrowRect.anchorMax = new(1f, 0.5f);
            arrowRect.anchorMin = new(1f, 0.5f);
            arrowRect.sizeDelta = new(20f, 20f);
            arrowRect.anchoredPosition = new(-15.658f, 0.088f);

            arrowGO.AddComponent<CanvasRenderer>();

            Image arrowImg = arrowGO.AddComponent<Image>();
            arrowImg.sprite = DropdownArrow;

            GameObject templateGO = new("Template");
            templateGO.transform.SetParent(innerGO.transform);
            templateGO.transform.localScale = Vector3.one;

            RectTransform templateRect = templateGO.AddComponent<RectTransform>();
            templateRect.anchorMax = new(1f, 0f);
            templateRect.anchorMin = Vector2.zero;
            templateRect.pivot = new(0.5f, 1f);
            templateRect.sizeDelta = new(0f, 180f);

            dropdown.template = templateRect;

            templateGO.AddComponent<CanvasRenderer>();

            Image templateImage = templateGO.AddComponent<Image>();
            templateImage.maskable = true;

            ScrollRect templateScrollRect = templateGO.AddComponent<ScrollRect>();
            templateScrollRect.horizontal = false;
            templateScrollRect.movementType = ScrollRect.MovementType.Clamped;
            templateScrollRect.scrollSensitivity = 35f;
            templateScrollRect.verticalScrollbarSpacing = -3f;
            templateScrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;

            GameObject viewportGO = new("Viewport");
            viewportGO.transform.SetParent(templateGO.transform);
            viewportGO.transform.localScale = Vector3.one;

            RectTransform viewportRect = viewportGO.AddComponent<RectTransform>();
            viewportRect.anchorMax = Vector2.one;
            viewportRect.anchorMin = Vector2.zero;
            viewportRect.pivot = new(0f, 1f);
            viewportRect.sizeDelta = new(-17f, 0f);
            viewportRect.anchoredPosition = Vector2.zero;

            templateScrollRect.viewport = viewportRect;

            Mask viewportMask = viewportGO.AddComponent<Mask>();
            viewportMask.showMaskGraphic = false;

            viewportGO.AddComponent<CanvasRenderer>();

            Image viewportImg = viewportGO.AddComponent<Image>();
            viewportImg.sprite = UIMask;
            viewportImg.type = Image.Type.Sliced;

            GameObject contentGO = new("Content");
            contentGO.transform.SetParent(viewportGO.transform);
            contentGO.transform.localScale = Vector3.one;

            RectTransform contentRect = contentGO.AddComponent<RectTransform>();
            contentRect.anchorMax = Vector2.one;
            contentRect.anchorMin = new(0f, 1f);
            contentRect.pivot = new(0.5f, 1f);
            contentRect.sizeDelta = new(0f, 28f);
            contentRect.anchoredPosition = Vector2.zero;

            templateScrollRect.content = contentRect;

            GameObject itemGO = new("Item");
            itemGO.transform.SetParent(contentGO.transform);
            itemGO.transform.localScale = Vector3.one;

            RectTransform itemRect = itemGO.AddComponent<RectTransform>();
            itemRect.anchorMax = new(1f, 0.5f);
            itemRect.anchorMin = new(0f, 0.5f);
            itemRect.sizeDelta = new(0f, 20f);
            itemRect.anchoredPosition = Vector2.zero;

            Toggle itemToggle = itemGO.AddComponent<Toggle>();
            itemToggle.isOn = true;

            GameObject itemBackgroundGO = new("Item Background");
            itemBackgroundGO.transform.SetParent(itemGO.transform);
            itemBackgroundGO.transform.localScale = Vector3.one;

            RectTransform itemBackgroundRect = itemBackgroundGO.AddComponent<RectTransform>();
            itemBackgroundRect.anchorMax = Vector3.one;
            itemBackgroundRect.anchorMin = Vector3.zero;
            itemBackgroundRect.sizeDelta = Vector3.zero;
            itemBackgroundRect.anchoredPosition = Vector2.zero;

            itemBackgroundGO.AddComponent<CanvasRenderer>();

            Image itemBackgroundImage = itemBackgroundGO.AddComponent<Image>();
            itemBackgroundImage.color = new(0.9608f, 0.9608f, 0.9608f, 1f);

            itemToggle.image = itemBackgroundImage;

            GameObject itemCheckmarkGO = new("Item Checkmark");
            itemCheckmarkGO.transform.SetParent(itemGO.transform);
            itemCheckmarkGO.transform.localScale = Vector3.one;

            RectTransform itemCheckmarkRect = itemCheckmarkGO.AddComponent<RectTransform>();
            itemCheckmarkRect.anchorMax = new(0f, 0.5f);
            itemCheckmarkRect.anchorMin = new(0f, 0.5f);
            itemCheckmarkRect.sizeDelta = new(20f, 20f);
            itemCheckmarkRect.anchoredPosition = new(10f, 0f);

            itemCheckmarkGO.AddComponent<CanvasRenderer>();

            Image itemCheckmarkImage = itemCheckmarkGO.AddComponent<Image>();
            itemCheckmarkImage.sprite = Checkmark;

            itemToggle.graphic = itemCheckmarkImage;

            GameObject itemLabelGO = new("Item Label");
            itemLabelGO.transform.SetParent(itemGO.transform);
            itemLabelGO.transform.localScale = Vector3.one;

            RectTransform itemLabelRect = itemLabelGO.AddComponent<RectTransform>();
            itemLabelRect.anchorMax = Vector2.one;
            itemLabelRect.anchorMin = Vector2.zero;
            itemLabelRect.sizeDelta = new(-30f, -3f);
            itemLabelRect.anchoredPosition = new(5f, -0.5f);

            itemLabelGO.AddComponent<CanvasRenderer>();

            TextMeshProUGUI itemLabelText = itemLabelGO.AddComponent<TextMeshProUGUI>();
            itemLabelText.font = RobotoBoldFont;
            itemLabelText.fontSize = 14f;
            itemLabelText.color = new(0.1961f, 0.1961f, 0.1961f, 1f);
            itemLabelText.alignment = TextAlignmentOptions.Left;

            dropdown.itemText = itemLabelText;

            GameObject scrollbarGO = new("Scrollbar");
            scrollbarGO.transform.SetParent(templateGO.transform);
            scrollbarGO.transform.localScale = Vector3.one;

            RectTransform scrollbarRect = scrollbarGO.AddComponent<RectTransform>();
            scrollbarRect.anchorMax = Vector2.one;
            scrollbarRect.anchorMin = new(1f, 0f);
            scrollbarRect.pivot = Vector2.one;
            scrollbarRect.sizeDelta = new(20f, 0f);
            scrollbarRect.anchoredPosition = Vector2.zero;

            scrollbarGO.AddComponent<CanvasRenderer>();

            Image scrollbarImage = scrollbarGO.AddComponent<Image>();
            scrollbarImage.color = new(0f, 0f, 0f, 0.2f);

            Scrollbar scrollbar = scrollbarGO.AddComponent<Scrollbar>();
            scrollbar.direction = Scrollbar.Direction.BottomToTop;
            scrollbar.size = 1f;

            templateScrollRect.verticalScrollbar = scrollbar;

            GameObject slidingAreaGO = new("Sliding Area");
            slidingAreaGO.transform.SetParent(scrollbarGO.transform);
            slidingAreaGO.transform.localScale = Vector3.one;

            RectTransform slidingAreaRect = slidingAreaGO.AddComponent<RectTransform>();
            slidingAreaRect.anchorMax = Vector2.one;
            slidingAreaRect.anchorMin = Vector2.zero;
            slidingAreaRect.sizeDelta = new(-10f, -10f);
            slidingAreaRect.anchoredPosition3D = new(0f, 0f, 5f);

            GameObject handleGO = new("Handle");
            handleGO.transform.SetParent(slidingAreaGO.transform);
            handleGO.transform.localScale = Vector3.one;

            RectTransform handleRect = handleGO.AddComponent<RectTransform>();
            handleRect.anchorMax = Vector2.one;
            handleRect.anchorMin = new(0f, 0.1556f);
            handleRect.sizeDelta = Vector2.zero;
            handleRect.anchoredPosition = Vector2.zero;

            scrollbar.handleRect = handleRect;

            handleGO.AddComponent<CanvasRenderer>();

            Image handleImage = handleGO.AddComponent<Image>();
            scrollbar.image = handleImage;

            GameObject applyGO = new("Apply");
            applyGO.transform.SetParent(dropdownGO.transform);
            applyGO.transform.localScale = Vector3.one;

            RectTransform applyRect = applyGO.AddComponent<RectTransform>();
            applyRect.sizeDelta = new(applyWidth, height);

            CanvasRenderer applyCanvasRenderer = applyGO.AddComponent<CanvasRenderer>();
            applyCanvasRenderer.cullTransparentMesh = false;

            Image applyImage = applyGO.AddComponent<Image>();
            applyImage.color = new(0f, 0f, 0f, 0.502f);

            Button applyButton = applyGO.AddComponent<Button>();
            applyButton.onClick.AddListener(
                crabDropdown,
                crabDropdown.GetIl2CppType().GetMethod(nameof(CrabDropdown.ApplyPressed))
            );
            applyButton.colors = new ColorBlock
            {
                normalColor = Color.white,
                highlightedColor = new(0.1792f, 0.1792f, 0.1792f, 1f),
                pressedColor = Color.black,
                selectedColor = new(0.9608f, 0.9608f, 0.9608f, 1f),
                disabledColor = new(0.7843f, 0.7843f, 0.7843f, 0.502f),
                colorMultiplier = 1f,
                fadeDuration = 0.1f
            };

            applyGO.AddComponent<ButtonSfx>();

            GameObject applyTextGO = new("Text (TMP)");
            applyTextGO.transform.SetParent(applyGO.transform);
            applyTextGO.transform.localScale = Vector3.one;

            RectTransform applyTextRect = applyTextGO.AddComponent<RectTransform>();
            applyTextRect.anchorMax = Vector2.one;
            applyTextRect.anchorMin = Vector2.zero;
            applyTextRect.sizeDelta = new(-10f, -10f);

            CanvasRenderer applyTextCanvasRenderer = applyTextGO.AddComponent<CanvasRenderer>();
            applyTextCanvasRenderer.cullTransparentMesh = false;

            TextMeshProUGUI applyText = applyTextGO.AddComponent<TextMeshProUGUI>();
            applyText.text = "Apply";
            applyText.font = RobotoBoldFont;
            applyText.fontSize = 32f;
            applyText.alignment = TextAlignmentOptions.Center;
            applyText.vertexBufferAutoSizeReduction = true;

            applyButton.targetGraphic = applyText;

            return crabDropdown;
        }

        public sealed class CrabDropdown : MonoBehaviour
        {
            internal TMP_Dropdown dropdown;

            [HideFromIl2Cpp] public event CrabCallback SelectCallback;
            [HideFromIl2Cpp] public event CrabCallback ApplyCallback;

            [HideFromIl2Cpp] public TMP_Dropdown Dropdown => dropdown;
            
            public void OptionSelected(int _)
            {
                SelectCallback?.Invoke();
            }

            public void ApplyPressed()
            {
                ApplyCallback?.Invoke();
            }
        }


        internal static class Patches
        {
            [HarmonyPatch(typeof(MainManager), nameof(MainManager.Awake))]
            [HarmonyPostfix]
            internal static void PostMainManagerAwake()
            {
                TMP_Settings.instance.m_warningsDisabled = true;

                SceneInit();
            }

            [HarmonyPatch(typeof(Settings), nameof(Settings.Start))]
            [HarmonyPriority(Priority.First)]
            [HarmonyPostfix]
            internal static void PostSettingsStart(Settings __instance)
            {
                SettingsMenu = __instance.gameObject;

                GetCategory(SettingsMenu, "Gameplay", out _, out _, out GameObject gameplayContentGO);
                GetCategory(SettingsMenu, "Controls", out _, out _, out GameObject controlsContentGO);
                GetCategory(SettingsMenu, "Graphics", out _, out _, out GameObject graphicsContentGO);
                GetCategory(SettingsMenu, "Video", out _, out _, out GameObject videoContentGO);
                GetCategory(SettingsMenu, "Audio", out _, out _, out GameObject audioContentGO);

                GameplaySettingsContent = gameplayContentGO;
                ControlsSettingsContent = controlsContentGO;
                GraphicsSettingsContent = graphicsContentGO;
                VideoSettingsContent = videoContentGO;
                AudioSettingsContent = audioContentGO;
            }
        }
    }

    /*private static void CreateCategory(string category, HashSet<CrabOption> settings)
    {
        Transform header = _settingsUi.transform.GetChild(0);
        Transform tabsParent = header.GetChild(0);
        GeneralUiInventoryTabs tabs = tabsParent.GetComponent<GeneralUiInventoryTabs>();

        // Create category tab button
        GameObject videoTab = tabsParent.GetChild(3).gameObject;

        GameObject categoryTab = UnityEngine.Object.Instantiate(videoTab, tabsParent);
        categoryTab.GetComponent<Button>().m_OnClick.m_PersistentCalls.m_Calls[0].m_Arguments.m_IntArgument = tabs.btns.Length;
        categoryTab.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = category;

        // Register tab button
        RawImage[] btns = new RawImage[tabs.btns.Length + 1];
        for (int i = 0; i < tabs.btns.Length; i++)
            btns[i] = tabs.btns[i];
        btns[^1] = categoryTab.GetComponent<RawImage>();
        tabs.btns = btns;

        // Create category content
        GameObject videoSettings = _settingsUi.transform.GetChild(4).gameObject;

        GameObject categorySettings = UnityEngine.Object.Instantiate(videoSettings, _settingsUi.transform);
        Transform categoryContainer = categorySettings.transform.GetChild(0);
        Transform categoryContent = categoryContainer.GetChild(0);
        for (int i = categoryContent.childCount - 1; i >= 0; i--)
            UnityEngine.Object.Destroy(categoryContent.GetChild(i).gameObject);

        // Register category content
        GameObject[] settingMenus = new GameObject[tabs.settingMenus.Length + 1];
        for (int i = 0; i < tabs.settingMenus.Length; i++)
            settingMenus[i] = tabs.settingMenus[i];
        settingMenus[^1] = categorySettings;
        tabs.settingMenus = settingMenus;

        // Create category settings
        foreach (CrabOption setting in settings)
            setting.Create(categoryContent);
    }*/
}