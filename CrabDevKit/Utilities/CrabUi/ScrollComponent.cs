using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CrabDevKit.Utilities.CrabUi
{
    public sealed class ScrollComponent : BaseSettingComponent
    {
        private int _initialState = 0;
        private object[] _options = null;

        private float _size = 40f;
        private float _textWidth = 300f;

        private TMP_FontAsset _font = CommonUi.RobotoBoldFont;
        private Color _textColor = Color.white;

        private Color _buttonColor = Color.white;

        private CustomScrollCallback _callback = null;


        public ScrollComponent WithInitialState(int initialState)
        {
            _initialState = initialState;
            return this;
        }

        public ScrollComponent WithOptions(object[] options)
        {
            _options = [.. options];
            return this;
        }


        public ScrollComponent WithSize(float size)
        {
            _size = size;
            return this;
        }

        public ScrollComponent WithTextWidth(float textWidth)
        {
            _textWidth = textWidth;
            return this;
        }


        public ScrollComponent WithFont(TMP_FontAsset font)
        {
            _font = font;
            return this;
        }

        public ScrollComponent WithTextColor(Color textColor)
        {
            _textColor = textColor;
            return this;
        }


        public ScrollComponent WithButtonColor(Color buttonColor)
        {
            _buttonColor = buttonColor;
            return this;
        }


        public ScrollComponent WithCallback(CustomScrollCallback callback)
        {
            _callback += callback;
            return this;
        }


        public new ScrollComponent WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }


        public override GameObject Build()
        {
            if (_options == null || _options.Length == 0)
                throw new Exception("options cannot be null or empty.");

            _initialState = Mathf.Clamp(_initialState, 0, _options.Length - 1);

            if (_font == null)
                throw new Exception("font cannot be null.");

            if (_parent == null)
                throw new Exception("parent cannot be null.");


            GameObject settingGO = new("Scroll Component");
            settingGO.transform.SetParent(_parent);
            settingGO.transform.localScale = Vector3.one;

            RectTransform rect = settingGO.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2((_size * 2f) + _textWidth, _size);

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

            CustomScrollCallback callback = null;
            CustomScroll customScroll = settingGO.AddComponent<CustomScroll>();


            GameObject leftGO = new("Left");
            leftGO.transform.SetParent(settingGO.transform);
            leftGO.transform.localScale = Vector3.one;

            RectTransform leftRect = leftGO.AddComponent<RectTransform>();
            leftRect.sizeDelta = Vector2.one * _size;
            
            CanvasRenderer leftCanvas = leftGO.AddComponent<CanvasRenderer>();
            leftCanvas.cullTransparentMesh = false;

            RawImage leftImage = leftGO.AddComponent<RawImage>();
            leftImage.enabled = false;
            leftImage.color = Color.red;


            GameObject leftButtonGO = new("Button");
            leftButtonGO.transform.SetParent(leftGO.transform);
            leftButtonGO.transform.localScale = new Vector3(-1f, 1f, 1f);

            RectTransform leftButtonRect = leftButtonGO.AddComponent<RectTransform>();
            leftButtonRect.sizeDelta = Vector2.one * _size;

            CanvasRenderer leftButtonCanvas = leftButtonGO.AddComponent<CanvasRenderer>();
            leftButtonCanvas.cullTransparentMesh = false;

            Button leftButton = leftButtonGO.AddComponent<Button>();
            leftButton.onClick.AddListener(
                customScroll,
                customScroll.GetIl2CppType().GetMethod(nameof(CustomScroll.ScrollLeft))
            );

            leftButtonGO.AddComponent<ButtonSfx>();

            RawImage leftButtonImg = leftButtonGO.AddComponent<RawImage>();
            leftButtonImg.texture = CommonUi.Arrow;
            leftButtonImg.color = _buttonColor;

            callback += (state, _, _) => leftButtonImg.enabled = state != 0;

            
            GameObject valueTextGO = new("Text");
            valueTextGO.transform.SetParent(settingGO.transform);
            valueTextGO.transform.localScale = Vector3.one;

            RectTransform valueTextRect = valueTextGO.AddComponent<RectTransform>();
            valueTextRect.sizeDelta = new Vector2(_textWidth, _size);

            CanvasRenderer valueTextCanvas = valueTextGO.AddComponent<CanvasRenderer>();
            valueTextCanvas.cullTransparentMesh = false;

            RawImage valueTextImage = valueTextGO.AddComponent<RawImage>();
            valueTextImage.enabled = false;
            valueTextImage.color = Color.red;


            GameObject textGO = new("Text (TMP)");
            textGO.transform.SetParent(valueTextGO.transform);
            textGO.transform.localScale = Vector3.one;

            RectTransform textRect = textGO.AddComponent<RectTransform>();
            textRect.sizeDelta = new Vector2(_textWidth, _size);

            CanvasRenderer textCanvas = textGO.AddComponent<CanvasRenderer>();
            textCanvas.cullTransparentMesh = false;

            TextMeshProUGUI text = textGO.AddComponent<TextMeshProUGUI>();
            text.font = _font;
            text.color = _textColor;
            text.alignment = TextAlignmentOptions.Center;
            text.verticalAlignment = VerticalAlignmentOptions.Middle;

            callback += (state, _, _) => text.text = customScroll.options[state].ToString();


            GameObject rightGO = new("Right");
            rightGO.transform.SetParent(settingGO.transform);
            rightGO.transform.localScale = Vector3.one;

            RectTransform rightRect = rightGO.AddComponent<RectTransform>();
            rightRect.sizeDelta = Vector2.one * _size;

            CanvasRenderer rightCanvas = rightGO.AddComponent<CanvasRenderer>();
            rightCanvas.cullTransparentMesh = false;

            RawImage rightImage = rightGO.AddComponent<RawImage>();
            rightImage.enabled = false;
            rightImage.color = Color.red;

            
            GameObject rightButonGO = new("Button");
            rightButonGO.transform.SetParent(rightGO.transform);
            rightButonGO.transform.localScale = Vector3.one;

            RectTransform rightButtonRect = rightButonGO.AddComponent<RectTransform>();
            rightButtonRect.sizeDelta = Vector2.one * _size;

            CanvasRenderer rightButtonCanvas = rightButonGO.AddComponent<CanvasRenderer>();
            rightButtonCanvas.cullTransparentMesh = false;

            Button rightButton = rightButonGO.AddComponent<Button>();
            rightButton.onClick.AddListener(
                customScroll,
                customScroll.GetIl2CppType().GetMethod(nameof(CustomScroll.ScrollRight))
            );

            rightButonGO.AddComponent<ButtonSfx>();

            RawImage rightButtonImg = rightButonGO.AddComponent<RawImage>();
            rightButtonImg.texture = CommonUi.Arrow;
            rightButtonImg.color = _buttonColor;

            callback += (state, _, _) => rightButtonImg.enabled = state != customScroll.options.Length - 1;


            callback += _callback;
            customScroll.state = _initialState;
            customScroll.options = [.. _options];
            customScroll.callback = callback;
            customScroll.UpdateState();


            return settingGO;
        }
    }
}