using CrabDevKit.Intermediary;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CrabDevKit.Utilities.CrabUi
{
    public sealed class KeybindComponent : BaseSettingComponent
    {
        private string _displayName = "Some Keybind";
        private KeyCode _initialKey = KeyCode.None;
        private Vector2 _size = new(300f, 40f);
        private TMP_FontAsset _font = CommonUi.RobotoBoldFont;
        private Color _textColor = Color.white;

        private ColorBlock _colors = new()
        {
            normalColor = new(0f, 0f, 0f, 0.502f),
            highlightedColor = new(0.7075f, 0.7075f, 0.7075f, 0.502f),
            pressedColor = new(0f, 0f, 0f, 1f),
            selectedColor = new(0f, 0f, 0f, 0.502f),
            disabledColor = new(0.7843f, 0.7843f, 0.7843f, 0.502f),
            colorMultiplier = 1f,
            fadeDuration = 0.1f
        };

        private CustomKeybindCallback _callback = null;


        public KeybindComponent WithDisplayName(string displayName)
        {
            _displayName = displayName;
            return this;
        }

        public KeybindComponent WithInitialKey(KeyCode initialKey)
        {
            _initialKey = initialKey;
            return this;
        }

        public KeybindComponent WithSize(float width, float height)
        {
            _size = new(width, height);
            return this;
        }

        public KeybindComponent WithFont(TMP_FontAsset font)
        {
            _font = font;
            return this;
        }

        public KeybindComponent WithTextColor(Color textColor)
        {
            _textColor = textColor;
            return this;
        }


        public KeybindComponent WithNormalColor(Color normalColor)
        {
            _colors.normalColor = normalColor;
            return this;
        }

        public KeybindComponent WithHighlightedColor(Color highlightedColor)
        {
            _colors.highlightedColor = highlightedColor;
            return this;
        }

        public KeybindComponent WithPressedColor(Color pressedColor)
        {
            _colors.pressedColor = pressedColor;
            return this;
        }

        public KeybindComponent WithSelectedColor(Color selectedColor)
        {
            _colors.selectedColor = selectedColor;
            return this;
        }

        public KeybindComponent WithDisabledColor(Color disabledColor)
        {
            _colors.disabledColor = disabledColor;
            return this;
        }

        public KeybindComponent WithColorMultiplier(float colorMultiplier)
        {
            _colors.colorMultiplier = colorMultiplier;
            return this;
        }
        
        public KeybindComponent WithFadeDuration(float fadeDuration)
        {
            _colors.fadeDuration = fadeDuration;
            return this;
        }


        public KeybindComponent WithCallback(CustomKeybindCallback callback)
        {
            _callback += callback;
            return this;
        }


        public new KeybindComponent WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }

        public override GameObject Build()
        {
            if (string.IsNullOrEmpty(_displayName))
                throw new Exception("displayName cannot be null or empty.");

            if (_initialKey == KeyCode.None || (!Enum.IsDefined(typeof(KeyCode), _initialKey) && (int)_initialKey != -1 && (int)_initialKey != -2))
                throw new Exception("initialKey cannot be None or invalid.");

            if (_font == null)
                throw new Exception("font cannot be null.");

            if (_parent == null)
                throw new Exception("parent cannot be null.");


            GameObject settingGO = new("Keybind Component");
            settingGO.transform.SetParent(_parent);
            settingGO.transform.localScale = Vector3.one;

            RectTransform rect = settingGO.AddComponent<RectTransform>();
            rect.sizeDelta = _size;

            CanvasRenderer canvas = settingGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = settingGO.AddComponent<RawImage>();
            img.enabled = false;
            img.color = Color.red;

            HorizontalLayoutGroup horizontal = settingGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlHeight = false;
            horizontal.childControlWidth = false;
            horizontal.childForceExpandHeight = false;
            horizontal.childForceExpandWidth = false;
            horizontal.childAlignment = TextAnchor.MiddleCenter;

            CustomKeybind customKeybind = settingGO.AddComponent<CustomKeybind>();
            customKeybind.setting = settingGO.AddComponent<ControlSetting>();


            GameObject buttonGO = new("Button");
            buttonGO.transform.SetParent(settingGO.transform);
            buttonGO.transform.localScale = Vector3.one;

            RectTransform buttonRect = buttonGO.AddComponent<RectTransform>();
            buttonRect.sizeDelta = _size;

            CanvasRenderer buttonCanvas = buttonGO.AddComponent<CanvasRenderer>();
            buttonCanvas.cullTransparentMesh = false;

            buttonGO.AddComponent<RawImage>();

            Button button = buttonGO.AddComponent<Button>();
            button.colors = _colors;
            button.onClick.AddListener(
                customKeybind.setting,
                customKeybind.setting.GetIl2CppType().GetMethod(nameof(ControlSetting.StartListening))
            );

            buttonGO.AddComponent<ButtonSfx>();


            GameObject textGO = new("Text (TMP)");
            textGO.transform.SetParent(buttonGO.transform);
            textGO.transform.localScale = Vector3.one;

            RectTransform textRect = textGO.AddComponent<RectTransform>();
            textRect.sizeDelta = _size;

            CanvasRenderer textCanvas = textGO.AddComponent<CanvasRenderer>();
            textCanvas.cullTransparentMesh = false;

            TextMeshProUGUI text = textGO.AddComponent<TextMeshProUGUI>();
            text.font = _font;
            text.color = _textColor;
            text.alignment = TextAlignmentOptions.Center;
            text.verticalAlignment = VerticalAlignmentOptions.Middle;

            CustomKeybindCallback callback = (key, _) => text.text = customKeybind.setting.intToKeyCode((int)customKeybind.key);


            GameObject fakeGO = new("Fake Text"); // fake text for ControlSetting to use on update
            fakeGO.transform.SetParent(textGO.transform);
            fakeGO.transform.localScale = Vector3.one;
            fakeGO.SetActive(false);

            RectTransform fakeRect = fakeGO.AddComponent<RectTransform>();
            fakeRect.sizeDelta = _size;

            customKeybind.setting.keyText = fakeGO.AddComponent<TextMeshProUGUI>();
            customKeybind.setting.keyText.enabled = false;


            customKeybind.setting.set_actionName(_displayName);
            customKeybind.setting.currentKey = (int)_initialKey;

            customKeybind.setting.m_OnClick.AddListener(
                customKeybind,
                customKeybind.GetIl2CppType().GetMethod(nameof(CustomKeybind.KeybindUpdated))
            );


            callback += _callback;
            customKeybind.callback = callback;
            customKeybind.SetKeybind(_initialKey);


            return settingGO;
        }
    }
}