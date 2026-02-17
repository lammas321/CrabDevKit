using System;
using UnityEngine;
using UnityEngine.UI;

namespace CrabDevKit.Utilities.CrabUi
{
    public sealed class ToggleComponent : BaseSettingComponent
    {
        private bool _initialState = false;
        private float _size = 40f;
        private Color _outerColor = Color.white;
        private Color _innerColor = Color.white;

        private readonly RectOffset _padding = new()
        {
            left = 0,
            right = 10,
            top = 0,
            bottom = 0
        };

        private CustomToggleCallback _callback = null;


        public ToggleComponent WithInitialState(bool initialState)
        {
            _initialState = initialState;
            return this;
        }

        public ToggleComponent WithSize(float size)
        {
            _size = size;
            return this;
        }

        public ToggleComponent WithOuterColor(Color outerColor)
        {
            _outerColor = outerColor;
            return this;
        }

        public ToggleComponent WithInnerColor(Color innerColor)
        {
            _innerColor = innerColor;
            return this;
        }


        public ToggleComponent WithPadding(int left, int right, int top, int bottom)
        {
            _padding.left = left;
            _padding.right = right;
            _padding.top = top;
            _padding.bottom = bottom;
            return this;
        }

        public ToggleComponent WithPadding(int horizontal, int vertical)
        {
            _padding.left = horizontal;
            _padding.right = horizontal;
            _padding.top = vertical;
            _padding.bottom = vertical;
            return this;
        }

        public ToggleComponent WithPadding(int padding)
        {
            _padding.left = padding;
            _padding.right = padding;
            _padding.top = padding;
            _padding.bottom = padding;
            return this;
        }


        public ToggleComponent WithCallback(CustomToggleCallback callback)
        {
            _callback += callback;
            return this;
        }


        public new ToggleComponent WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }


        public override GameObject Build()
        {
            if (_parent == null)
                throw new Exception("parent cannot be null.");

            
            GameObject settingGO = settingGO = new("Toggle Component");
            settingGO.transform.SetParent(_parent);
            settingGO.transform.localScale = Vector3.one;

            RectTransform rect = settingGO.AddComponent<RectTransform>();
            rect.sizeDelta = Vector2.one * _size;

            CanvasRenderer canvas = settingGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = settingGO.AddComponent<RawImage>();
            img.enabled = false;
            img.color = Color.red;

            HorizontalLayoutGroup horizontal = settingGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlHeight = false;
            horizontal.childControlWidth = false;
            horizontal.childForceExpandHeight = true;
            horizontal.childForceExpandWidth = true;
            horizontal.childAlignment = TextAnchor.MiddleRight;

            horizontal.padding.left = _padding.left;
            horizontal.padding.right = _padding.right;
            horizontal.padding.top = _padding.top;
            horizontal.padding.bottom = _padding.bottom;


            GameObject buttonGO = new("Button");
            buttonGO.transform.SetParent(settingGO.transform);
            buttonGO.transform.localScale = Vector3.one;

            RectTransform buttonRect = buttonGO.AddComponent<RectTransform>();
            buttonRect.sizeDelta = Vector2.one * _size;

            CanvasRenderer buttonCanvas = buttonGO.AddComponent<CanvasRenderer>();
            buttonCanvas.cullTransparentMesh = false;

            CustomToggle customToggle = buttonGO.AddComponent<CustomToggle>();

            Button button = buttonGO.AddComponent<Button>();
            button.onClick.AddListener(
                customToggle,
                customToggle.GetIl2CppType().GetMethod(nameof(CustomToggle.ButtonPressed))
            );

            RawImage buttonImg = buttonGO.AddComponent<RawImage>();
            buttonImg.texture = CommonUi.HollowCircle;
            buttonImg.color = _outerColor;

            buttonGO.AddComponent<ButtonSfx>();


            GameObject toggleGO = new("Toggle");
            toggleGO.transform.SetParent(buttonGO.transform);
            toggleGO.transform.localScale = Vector3.one * 0.5f;
            toggleGO.SetActive(_initialState);

            RectTransform toggleRect = toggleGO.AddComponent<RectTransform>();
            toggleRect.sizeDelta = Vector2.zero;
            toggleRect.anchorMin = Vector2.zero;
            toggleRect.anchorMax = Vector2.one;

            CanvasRenderer toggleCanvas = toggleGO.AddComponent<CanvasRenderer>();
            toggleCanvas.cullTransparentMesh = false;

            RawImage toggleImg = toggleGO.AddComponent<RawImage>();
            toggleImg.texture = CommonUi.Circle;
            toggleImg.color = _innerColor;

            CustomToggleCallback callback = null;

            callback += (state, _) => toggleGO.SetActive(state);


            callback += _callback;
            customToggle.state = !_initialState;
            customToggle.callback = callback;
            customToggle.ButtonPressed();


            return settingGO;
        }
    }
}