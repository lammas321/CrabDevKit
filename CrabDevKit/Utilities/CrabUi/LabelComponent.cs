using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CrabDevKit.Utilities.CrabUi
{
    public sealed class LabelComponent : BaseSettingComponent
    {
        private string _label = "Basic Label";
        private Vector2 _size = new(0f, 40f);
        private TMP_FontAsset _font = CommonUi.RobotoBoldFont;
        private Color _textColor = Color.white;

        private bool _childControlWidth = true;
        private bool _childControlHeight = true;
        private bool _childForceExpandWidth = true;
        private bool _childForceExpandHeight = true;
        private bool _childScaleWidth = false;
        private bool _childScaleHeight = false;


        public LabelComponent WithLabel(string label)
        {
            _label = label;
            return this;
        }

        public LabelComponent WithSize(float width, float height)
        {
            _size = new(width, height);
            return this;
        }

        public LabelComponent WithFont(TMP_FontAsset font)
        {
            _font = font;
            return this;
        }

        public LabelComponent WithTextColor(Color textColor)
        {
            _textColor = textColor;
            return this;
        }


        public LabelComponent WithChildControl(bool width, bool height)
        {
            _childControlWidth = width;
            _childControlHeight = height;
            return this;
        }

        public LabelComponent WithChildForceExpand(bool width, bool height)
        {
            _childForceExpandWidth = width;
            _childForceExpandHeight = height;
            return this;
        }

        public LabelComponent WithScale(bool width, bool height)
        {
            _childScaleWidth = width;
            _childScaleHeight = height;
            return this;
        }


        public new LabelComponent WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }


        public override GameObject Build()
        {
            if (string.IsNullOrEmpty(_label))
                throw new Exception("label cannot be null or empty.");

            if (_font == null)
                throw new Exception("font cannot be null.");

            if (_parent == null)
                throw new Exception("parent cannot be null.");


            GameObject settingGO = new("Label Component");
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
            horizontal.childControlWidth = _childControlWidth;
            horizontal.childControlHeight = _childControlHeight;
            horizontal.childForceExpandHeight = _childForceExpandWidth;
            horizontal.childForceExpandWidth = _childForceExpandHeight;
            horizontal.childScaleWidth = _childScaleWidth;
            horizontal.childScaleHeight = _childScaleHeight;
            horizontal.childAlignment = TextAnchor.MiddleLeft;


            GameObject textGO = new("Text (TMP)");
            textGO.transform.SetParent(settingGO.transform);
            textGO.transform.localScale = Vector3.one;

            RectTransform textRect = textGO.AddComponent<RectTransform>();
            textRect.sizeDelta = _size;

            CanvasRenderer textCanvas = textGO.AddComponent<CanvasRenderer>();
            textCanvas.cullTransparentMesh = false;

            TextMeshProUGUI text = textGO.AddComponent<TextMeshProUGUI>();
            text.text = _label;
            text.font = _font;
            text.color = _textColor;
            text.alignment = TextAlignmentOptions.Left;
            text.verticalAlignment = VerticalAlignmentOptions.Middle;


            return settingGO;
        }
    }
}