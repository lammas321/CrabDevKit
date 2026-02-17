using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CrabDevKit.Utilities.CrabUi
{
    public sealed class ButtonComponent : BaseSettingComponent
    {
        private float _height = 40f;
        private Vector2 _size = new(151.92f, 39.3f);

        private float _glossWidth = 20f;
        private float _glossHeight = 12f;

        private readonly RectOffset _padding = new()
        {
            left = 0,
            right = 10,
            top = 0,
            bottom = 0
        };

        private Color _buttonColor = new(1f, 0f, 0.0285f, 1f);

        private ColorBlock _colors = new()
        {
            normalColor = Color.white,
            highlightedColor = new(0.7453f, 0.7453f, 0.7453f, 1f),
            pressedColor = new(0.5f, 0.5f, 0.5f, 1f),
            selectedColor = new(0.9608f, 0.9608f, 0.9608f, 1f),
            disabledColor = new(0.7843f, 0.7843f, 0.7843f, 0.502f),
            colorMultiplier = 1f,
            fadeDuration = 0.1f
        };

        private TMP_FontAsset _font = CommonUi.RobotoBoldUnderlayFont;
        private Color _textColor = Color.white;

        private CustomButtonCallback _callback = null;


        public ButtonComponent WithHeight(float height)
        {
            _height = height;
            return this;
        }

        public ButtonComponent WithSize(float width, float height)
        {
            _size = new(width, height);
            return this;
        }


        public ButtonComponent WithGlossWidth(float glossWidth)
        {
            _glossWidth = glossWidth;
            return this;
        }

        public ButtonComponent WithGlossHeight(float glossHeight)
        {
            _glossHeight = glossHeight;
            return this;
        }


        public ButtonComponent WithPadding(int left, int right, int top, int bottom)
        {
            _padding.left = left;
            _padding.right = right;
            _padding.top = top;
            _padding.bottom = bottom;
            return this;
        }

        public ButtonComponent WithPadding(int horizontal, int vertical)
        {
            _padding.left = horizontal;
            _padding.right = horizontal;
            _padding.top = vertical;
            _padding.bottom = vertical;
            return this;
        }

        public ButtonComponent WithPadding(int padding)
        {
            _padding.left = padding;
            _padding.right = padding;
            _padding.top = padding;
            _padding.bottom = padding;
            return this;
        }


        public ButtonComponent WithNormalColor(Color normalColor)
        {
            _colors.normalColor = normalColor;
            return this;
        }

        public ButtonComponent WithHighlightedColor(Color highlightedColor)
        {
            _colors.highlightedColor = highlightedColor;
            return this;
        }

        public ButtonComponent WithPressedColor(Color pressedColor)
        {
            _colors.pressedColor = pressedColor;
            return this;
        }

        public ButtonComponent WithSelectedColor(Color selectedColor)
        {
            _colors.selectedColor = selectedColor;
            return this;
        }

        public ButtonComponent WithDisabledColor(Color disabledColor)
        {
            _colors.disabledColor = disabledColor;
            return this;
        }

        public ButtonComponent WithColorMultiplier(float colorMultiplier)
        {
            _colors.colorMultiplier = colorMultiplier;
            return this;
        }

        public ButtonComponent WithFadeDuration(float fadeDuration)
        {
            _colors.fadeDuration = fadeDuration;
            return this;
        }


        public ButtonComponent WithFont(TMP_FontAsset font)
        {
            _font = font;
            return this;
        }

        public ButtonComponent WithTextColor(Color textColor)
        {
            _textColor = textColor;
            return this;
        }


        public ButtonComponent WithCallback(CustomButtonCallback callback)
        {
            _callback += callback;
            return this;
        }


        public new ButtonComponent WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }


        public override GameObject Build()
        {
            if (_font == null)
                throw new Exception("font cannot be null.");

            if (_parent == null)
                throw new Exception("parent cannot be null.");

            /*
             * Button Component
             * - RectTransform
             *   sizeDelta = new(sizeDelta.x, _height);
             *   
             * - CanvasRenderer
             *   cullTransparentMesh = false;
             * 
             * - RawImage
             *   color = Color.red;
             *   enabled = false;
             *   
             * - HorizontalLayoutGroup
             *   childControlWidth = false;
             *   childControlHeight = false;
             *   padding.left = _padding.left;
             *   padding.right = _padding.right;
             *   padding.top = _padding.top;
             *   padding.bottom = _padding.bottom;
             * 
             * - UiButtonKids
             *   - RectTransform
             *     anchorMax = new(0f, 1f);
             *     anchorMin = new(0f, 1f);
             *     sizeDelta = _size;
             *     
             *   - CanvasRenderer
             *   
             *   - Image
             *     color = _buttonColor;
             *   
             *   - Button
             *     onClick.AddListener(...);
             *     colors = _colors;
             *   
             *   - ButtonSfx
             *   
             *   - Top Gloss
             *     - RectTransform
             *       anchorMax = new(1f, 1f);
             *       anchorMin = new(0f, 1f
             *       pivot = new(0.5f, 0f
             *       sizeDelta = new(0f, _glossHeight);
             *     
             *     - CanvasRenderer
             *     
             *     - RawImage
             *       color = new(0f, 0f, 0f, 0.3569f);
             *       texture = CommonUi.GradientBottLong;
             *   
             *   - Bottom Gloss
             *     - RectTransform
             *       anchorMax = new(1f, 0f);
             *       anchorMin = new(0f, 0f
             *       pivot = new(0.5f, 0f
             *       sizeDelta = new(0f, _glossHeight);
             *     
             *     - CanvasRenderer
             *     
             *     - RawImage
             *       color = new(0f, 0f, 0f, 0.3569f);
             *       texture = CommonUi.GradientBottLong;
             *   
             *   - Left Gloss
             *     - RectTransform
             *       anchorMax = new(0f, 1f);
             *       anchorMin = new(0f, 0f
             *       pivot = new(0f, 0.5f
             *       sizeDelta = new(_glossWidth, 0f);
             *     
             *     - CanvasRenderer
             *     
             *     - RawImage
             *       color = new(0f, 0f, 0f, 0.3569f);
             *       texture = CommonUi.GradientBottLong;
             *   
             *   - Right Gloss
             *     - RectTransform
             *       anchorMax = new(1f, 1f);
             *       anchorMin = new(1f, 0f
             *       pivot = new(0f, 0.5f
             *       sizeDelta = new(_glossWidth, 0f);
             *     
             *     - CanvasRenderer
             *     
             *     - RawImage
             *       color = new(0f, 0f, 0f, 0.3569f);
             *       texture = CommonUi.GradientBottLong;
             *   
             *   - Text (TMP)
             *     - RectTransform
             *     
             *     - CanvasRenderer
             *     
             *     - TMPro.TextMeshProUGUI
             *       font = _font;
             *       color = _textColor;
             *     
             */





            return null;
        }
    }
}