using UnityEngine;

namespace CrabDevKit.Utilities.CrabUi
{
    public abstract class BaseSettingComponent
    {
        protected Transform _parent = null;

        public BaseSettingComponent WithParent(Transform parent)
        {
            _parent = parent;
            return this;
        }

        public abstract GameObject Build(); 
    }
}