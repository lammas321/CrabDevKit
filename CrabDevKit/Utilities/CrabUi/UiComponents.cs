using System;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.UI;

// TODO

// Buttons (ex. Reset Save)
// Dropdowns (ex. Resolution/Microphone)
// Text boxes (ex. Server name)

namespace CrabDevKit.Utilities.CrabUi
{
    internal static class UiComponents
    {
        internal static void Init()
        {
            ClassInjector.RegisterTypeInIl2Cpp<CustomButton>();
            ClassInjector.RegisterTypeInIl2Cpp<CustomKeybind>();
            ClassInjector.RegisterTypeInIl2Cpp<CustomScroll>();
            ClassInjector.RegisterTypeInIl2Cpp<CustomSlider>();
            ClassInjector.RegisterTypeInIl2Cpp<CustomToggle>();
        }
    }


    public delegate void CustomButtonCallback();

    internal sealed class CustomButton : MonoBehaviour
    {
        internal CustomButtonCallback callback;

        public void ButtonPressed()
        {
            callback?.Invoke();
        }
    }


    public delegate void CustomKeybindCallback(KeyCode key, Action<KeyCode> setKey);

    internal sealed class CustomKeybind : MonoBehaviour
    {
        internal KeyCode key;
        internal CustomKeybindCallback callback;
        internal ControlSetting setting;

        public void KeybindUpdated()
        {
            SetKeybind((KeyCode)setting.currentKey);
        }

        internal void SetKeybind(KeyCode key)
        {
            this.key = key;
            callback?.Invoke(this.key, SetKeybind);
        }
    }


    public delegate void CustomScrollCallback(int state, Action<int> setState, Action<object[]> setOptions);

    internal sealed class CustomScroll : MonoBehaviour
    {
        internal int state;
        internal object[] options;
        internal CustomScrollCallback callback;

        public void ScrollLeft()
        {
            state--;
            if (state < 0)
                state = 0;

            UpdateState();
        }

        public void ScrollRight()
        {
            state++;
            if (state >= options.Length)
                state = options.Length - 1;

            UpdateState();
        }

        internal void UpdateState()
            => callback?.Invoke(state, SetState, SetOptions);

        private void SetState(int state)
        {
            this.state = Mathf.Clamp(state, 0, options.Length - 1);
            UpdateState();
        }

        private void SetOptions(object[] options)
        {
            if (options == null || options.Length < 0)
                return;

            this.options = [.. options];
            state = Mathf.Clamp(state, 0, this.options.Length - 1);
            UpdateState();
        }
    }


    public delegate void CustomSliderCallback(int state, Slider slider);

    internal sealed class CustomSlider : MonoBehaviour
    {
        internal Slider slider;
        internal CustomSliderCallback callback;

        public void SliderUpdated(float state)
            => callback?.Invoke(Mathf.RoundToInt(state), slider);
    }


    public delegate void CustomToggleCallback(bool state, Action toggle);

    internal sealed class CustomToggle : MonoBehaviour
    {
        internal bool state;
        internal CustomToggleCallback callback;

        public void ButtonPressed()
        {
            state = !state;
            callback?.Invoke(state, ButtonPressed);
        }
    }
}