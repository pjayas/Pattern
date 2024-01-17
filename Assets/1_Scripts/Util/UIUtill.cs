using PUtil;
using UnityEngine.UI;
using UnityEngine;


namespace PUtil
{
    public static class UIUtil
    {
        public static void SetBtnClick(Button _btn, UnityEngine.Events.UnityAction _click)
        {
            if (null == _btn)
                return;

            _btn.onClick.AddListener(_click);
        }

        public static void SetBtnClick(Button[] _btns, UnityEngine.Events.UnityAction _click)
        {
            if (null == _btns)
                return;

            for (int i = 0; i < _btns.Length; ++i)
            {
                SetBtnClick(_btns[i], _click);
            }
        }

        public static void SetAlpha(Graphic _graphic, float _alpha)
        {
            if (null == _graphic)
                return;

            Color _color = _graphic.color;
            _color.a = _alpha;
            _graphic.color = _color;
        }

        public static void SetAlpha(Graphic[] _graphics, float _alpha)
        {
            if (null == _graphics)
                return;

            for (int i = 0; i < _graphics.Length; ++i)
            {
                SetAlpha(_graphics[i], _alpha);
            }
        }

        public static bool IsOpen(MonoBase _mono)
        {
            if (null == _mono)
                return false;

            return _mono.isOpen;
        }
    }
}