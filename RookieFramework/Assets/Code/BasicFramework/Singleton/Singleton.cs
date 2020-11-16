// personal license onlyps

/*=============================================================================
	 Singleton.cs
	 2020-11-14 14:29 created by zipzap <zipzap92@163.com>
	 DESC: 非mono类单例。
	 单例应该集中创建对象，因此不需要多余的线程安全判断
=============================================================================*/

namespace ZipZap.BasicFramework 
{
    public abstract class Singleton<T> where T:new()
    {
        private static T s_instance;

        public static T Instance {
            get {
                if (s_instance == null) {
                    s_instance = new T();
                }
                    
                return s_instance;
            }
        }
    }
}