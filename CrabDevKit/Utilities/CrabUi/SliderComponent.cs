using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CrabDevKit.Utilities.CrabUi
{
    public sealed class SliderComponent : BaseSettingComponent
    {
        private int _minState = 0;
        private int _maxState = 10;
        private int _initialState = 5;

        private Vector2 _size = new(230f, 40f);
        private float _fillHeight = 10f;
        private float _handleWidth = 15f;
        private Vector2 _valueSize = new(90f, 40f);

        private TMP_FontAsset _font = CommonUi.RobotoBoldFont;
        private Color _textColor = Color.white;

        private Color _backgroundColor = new(0f, 0f, 0f, 0.5804f);
        private Color _fillColor = new(0.2235f, 0.2745f, 0.8f);
        private Color _valueTextBackgroundColor = new(0f, 0f, 0f, 0.502f);

        private CustomSliderCallback _callback = null;
        

        public SliderComponent WithMinState(int minState)
        {
            _minState = minState;
            return this;
        }

        public SliderComponent WithMaxState(int maxState)
        {
            _maxState = maxState;
            return this;
        }

        public SliderComponent WithInitialState(int initialState)
        {
            _initialState = initialState;
            return this;
        }


        public SliderComponent WithSize(float width, float height)
        {
            _size = new(width, height);
            return this;
        }

        public SliderComponent WithFillHeight(float fillHeight)
        {
            _fillHeight = fillHeight;
            return this;
        }

        public SliderComponent WithHandleWidth(float handleWidth)
        {
            _handleWidth = handleWidth;
            return this;
        }

        public SliderComponent WithValueSize(float width, float height)
        {
            _valueSize = new(width, height);
            return this;
        }


        public SliderComponent WithFont(TMP_FontAsset font)
        {
            _font = font;
            return this;
        }

        public SliderComponent WithTextColor(Color textColor)
        {
            _textColor = textColor;
            return this;
        }


        public SliderComponent WithBackgroundColor(Color backgroundColor)
        {
            _backgroundColor = backgroundColor;
            return this;
        }

        public SliderComponent WithFillColor(Color fillColor)
        {
            _fillColor = fillColor;
            return this;
        }
        
        public SliderComponent WithValueTextBackgroundColor(Color valueTextBackgroundColor)
        {
            _valueTextBackgroundColor = valueTextBackgroundColor;
            return this;
        }


        public SliderComponent WithCallback(CustomSliderCallback callback)
        {
            _callback += callback;
            return this;
        }


        public new SliderComponent WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }


        public override GameObject Build()
        {
            if (_minState > _maxState)
                throw new Exception("minState should be less than or equal to maxState.");

            _initialState = Mathf.Clamp(_initialState, _minState, _maxState);

            if (_font == null)
                throw new Exception("font cannot be null.");

            if (_parent == null)
                throw new Exception("parent cannot be null.");


            GameObject settingGO = settingGO = new("Slider Component");
            settingGO.transform.SetParent(_parent);
            settingGO.transform.localScale = Vector3.one;

            RectTransform rect = settingGO.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(_size.x + _valueSize.x + 25f, _size.y);

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
            horizontal.spacing = 25f;
            horizontal.childAlignment = TextAnchor.MiddleCenter;
            

            GameObject sliderGO = new("Slider");
            sliderGO.transform.SetParent(settingGO.transform);
            sliderGO.transform.localScale = Vector3.one;

            RectTransform sliderRect = sliderGO.AddComponent<RectTransform>();
            sliderRect.sizeDelta = _size;

            CustomSlider customSlider = sliderGO.AddComponent<CustomSlider>();

            Slider slider = sliderGO.AddComponent<Slider>();
            slider.wholeNumbers = true;
            slider.minValue = _minState;
            slider.maxValue = _maxState;
            slider.value = _initialState;
            slider.onValueChanged.AddListener(
                customSlider,
                customSlider.GetIl2CppType().GetMethod(nameof(CustomSlider.SliderUpdated))
            );

            customSlider.slider = slider;


            GameObject backgroundGO = new("Background");
            backgroundGO.transform.SetParent(sliderGO.transform);
            backgroundGO.transform.localScale = Vector3.one;

            RectTransform backgroundRect = backgroundGO.AddComponent<RectTransform>();
            backgroundRect.anchorMax = new Vector2(0.9787f, 0.75f);
            backgroundRect.anchorMin = new Vector2(0.0213f, 0.25f);
            backgroundRect.sizeDelta = new Vector2(0f, -_fillHeight);

            CanvasRenderer backgroundCanvas = backgroundGO.AddComponent<CanvasRenderer>();
            backgroundCanvas.cullTransparentMesh = false;

            Image backgroundImg = backgroundGO.AddComponent<Image>();
            backgroundImg.color = _backgroundColor;


            GameObject fillAreaGO = new("Fill Area");
            fillAreaGO.transform.SetParent(sliderGO.transform);
            fillAreaGO.transform.localScale = Vector3.one;

            RectTransform fillAreaRect = fillAreaGO.AddComponent<RectTransform>();
            fillAreaRect.anchorMax = new Vector2(0.9787f, 0.75f);
            fillAreaRect.anchorMin = new Vector2(0.0213f, 0.25f);
            fillAreaRect.sizeDelta = new Vector2(0f, -_fillHeight);


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
            fillImg.color = _fillColor;

            slider.fillRect = fillRect;


            GameObject slideAreaGO = new("Handle Slide Area");
            slideAreaGO.transform.SetParent(sliderGO.transform);
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
            handleRect.sizeDelta = new Vector2(_handleWidth, 0f);

            CanvasRenderer handleCanvas = handleGO.AddComponent<CanvasRenderer>();
            handleCanvas.cullTransparentMesh = false;

            handleGO.AddComponent<Image>();

            handleGO.AddComponent<ButtonSfx>();

            slider.handleRect = handleRect;


            CustomSliderCallback callback = null;

            GameObject valueTextGO = new("Value Text");
            valueTextGO.transform.SetParent(settingGO.transform);
            valueTextGO.transform.localScale = Vector3.one;

            RectTransform valueTextRect = valueTextGO.AddComponent<RectTransform>();
            valueTextRect.sizeDelta = _valueSize;

            CanvasRenderer valueTextCanvas = valueTextGO.AddComponent<CanvasRenderer>();
            valueTextCanvas.cullTransparentMesh = false;

            RawImage valueTextImage = valueTextGO.AddComponent<RawImage>();
            valueTextImage.color = _valueTextBackgroundColor;


            GameObject textGO = new("Text (TMP)");
            textGO.transform.SetParent(valueTextGO.transform);
            textGO.transform.localScale = Vector3.one;

            RectTransform textRect = textGO.AddComponent<RectTransform>();
            textRect.sizeDelta = _valueSize;

            CanvasRenderer textCanvas = textGO.AddComponent<CanvasRenderer>();
            textCanvas.cullTransparentMesh = false;

            TextMeshProUGUI text = textGO.AddComponent<TextMeshProUGUI>();
            text.font = _font;
            text.color = _textColor;
            text.alignment = TextAlignmentOptions.Center;
            text.verticalAlignment = VerticalAlignmentOptions.Middle;

            callback += (state, _) => text.text = state.ToString();


            callback += _callback;
            customSlider.callback = callback;
            customSlider.SliderUpdated(_initialState);


            return settingGO;
        }
    }
}