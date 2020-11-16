// personal license onlyps

/*=============================================================================
	 SingletonMono.cs
	 2020-11-14 14:31 created by zipzap <zipzap92@163.com>
	 DESC: 继承mono behaviour的单例。全局存在，永不销毁对象。
=============================================================================*/
using UnityEngine;

namespace ZipZap.BasicFramework 
{
    public abstract class SingletonMono<T>: MonoBehaviour where T : Object {
        private static T s_instance;

        public static T Instance {
            get {
                if (s_instance == null) {
                    s_instance = GameObject.FindObjectOfType<T>();
                    if (s_instance == null) {
                        s_instance = new GameObject($"[{typeof(T).Name}]",typeof(T)).GetComponent<T>();
                        DontDestroyOnLoad(s_instance);
                    }
                }

                return s_instance;
            }
        }
    }
}