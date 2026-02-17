using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CrabDevKit.Utilities.CrabUi
{
    public sealed class SettingBuilder : BaseSettingComponent
    {
        private string _name = "Basic Setting";
        private Vector2 _size = new(0f, 50f);
        private Color _backgroundColor = new(0f, 0f, 0f, 0.298f);

        private bool _childControlWidth = true;
        private bool _childControlHeight = true;
        private bool _childForceExpandWidth = false;
        private bool _childForceExpandHeight = false;
        private bool _childScaleWidth = false;
        private bool _childScaleHeight = false;

        private bool _reverseArangement = false;
        private float _spacing = 5f;
        private readonly RectOffset _padding = new()
        {
            left = 15,
            right = 15,
            top = 5,
            bottom = 5
        };


        public List<GameObject> BuiltComponents;
        private readonly List<BaseSettingComponent> _components = [];

        
        public SettingBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public SettingBuilder WithSize(float width, float height)
        {
            _size = new(width, height);
            return this;
        }

        public SettingBuilder WithBackgroundColor(Color backgroundColor)
        {
            _backgroundColor = backgroundColor;
            return this;
        }
        

        public SettingBuilder WithChildControl(bool width, bool height)
        {
            _childControlWidth = width;
            _childControlHeight = height;
            return this;
        }

        public SettingBuilder WithChildForceExpand(bool width, bool height)
        {
            _childForceExpandWidth = width;
            _childForceExpandHeight = height;
            return this;
        }

        public SettingBuilder WithScale(bool width, bool height)
        {
            _childScaleWidth = width;
            _childScaleHeight = height;
            return this;
        }


        public SettingBuilder WithReversedArrangement(bool reverseArrangement)
        {
            _reverseArangement = reverseArrangement;
            return this;
        }

        public SettingBuilder WithSpacing(float spacing)
        {
            _spacing = spacing;
            return this;
        }

        public SettingBuilder WithPadding(int left, int right, int top, int bottom)
        {
            _padding.left = left;
            _padding.right = right;
            _padding.top = top;
            _padding.bottom = bottom;
            return this;
        }

        public SettingBuilder WithPadding(int horizontal, int vertical)
        {
            _padding.left = horizontal;
            _padding.right = horizontal;
            _padding.top = vertical;
            _padding.bottom = vertical;
            return this;
        }

        public SettingBuilder WithPadding(int padding)
        {
            _padding.left = padding;
            _padding.right = padding;
            _padding.top = padding;
            _padding.bottom = padding;
            return this;
        }


        public new SettingBuilder WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }


        public SettingBuilder WithComponent(BaseSettingComponent component)
        {
            _components.Add(component);
            return this;
        }

        public SettingBuilder WithComponents(params IEnumerable<BaseSettingComponent> components)
        {
            _components.AddRange(components);
            return this;
        }


        public override GameObject Build()
        {
            if (string.IsNullOrEmpty(_name))
                throw new Exception("name cannot be null or empty.");

            if (_parent == null)
                throw new Exception("parent cannot be null.");


            GameObject settingGO = new(_name);
            settingGO.transform.SetParent(_parent);
            settingGO.transform.localScale = Vector3.one;

            RectTransform rect = settingGO.AddComponent<RectTransform>();
            rect.sizeDelta = _size;

            CanvasRenderer canvas = settingGO.AddComponent<CanvasRenderer>();
            canvas.cullTransparentMesh = false;

            RawImage img = settingGO.AddComponent<RawImage>();
            img.color = _backgroundColor;


            HorizontalLayoutGroup horizontal = settingGO.AddComponent<HorizontalLayoutGroup>();
            horizontal.childControlWidth = _childControlWidth;
            horizontal.childControlHeight = _childControlHeight;
            horizontal.childForceExpandHeight = _childForceExpandWidth;
            horizontal.childForceExpandWidth = _childForceExpandHeight;
            horizontal.childScaleWidth = _childScaleWidth;
            horizontal.childScaleHeight = _childScaleHeight;

            horizontal.reverseArrangement = _reverseArangement;
            horizontal.spacing = _spacing;
            horizontal.padding.left = _padding.left;
            horizontal.padding.right = _padding.right;
            horizontal.padding.top = _padding.top;
            horizontal.padding.bottom = _padding.bottom;


            BuiltComponents = new(_components.Count);
            foreach (BaseSettingComponent component in _components)
                try
                {
                    BuiltComponents.Add(component.WithParent(settingGO.transform).Build());
                }
                catch (Exception e)
                {
                    BuiltComponents.Add(null);
                    CrabDevKit.Instance.Log.LogError(e);
                }


            return settingGO;
        }
    }
}