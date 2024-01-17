using PUtil;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace PUtil
{
    public static class ResUtil
    {
        public static T Load<T>(string _path) where T : Object
        {
            if (string.IsNullOrWhiteSpace(_path) == true)
            {
                Debug.LogError("ResUtil::Load() null == path " + _path);
                return null;
            }

            T _res = Resources.Load<T>(_path);
            if (null == _res)
            {
                Debug.LogError("ResUtil::Load() No have File : " + _path);
                return null;
            }

            return _res;
        }

        public static GameObject Create(string _path, Transform _parent)
        {
            GameObject _res = Load<GameObject>(_path);
            if (null == _res)
                return null;

            GameObject _instantiate = GameObject.Instantiate<GameObject>(_res);
            if (null != _parent)
            {
                _instantiate.transform.SetParent(_parent);
            }

            return _instantiate;
        }

    }
}