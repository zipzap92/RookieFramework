// personal license onlyps

/*=============================================================================
	 ModuleMgr.cs
	 2020-11-14 14:36 created by zipzap <zipzap92@163.com>
	 DESC: 模块管理基类
	 GInit GClear 成对出现，表示全局初始化和清理
	 OnEnterScene OnLeaveScene 成对出现，表示针对特定场景的初始化和清理
=============================================================================*/
namespace ZipZap.BasicFramework 
{
    public abstract class ModuleMgr<T> : Singleton<T> where T : new() 
    {

        /// <summary>
        /// 全局初始化
        /// 框架启动之初即调用
        /// </summary>
        public abstract void GInit();

        /// <summary>
        /// 全局清理
        /// 注销，重新登录调用
        /// </summary>
        public abstract void GClear();

        /// <summary>
        /// 进入相关场景调用
        /// 通用模块一般不关心当前场景，比如装备，人物属性等
        /// 属于特定场景的才需要此接口
        /// </summary>
        public virtual void OnEnterScene(){}

        /// <summary>
        /// 离开相关场景调用
        /// </summary>
        public virtual void OnLeaveScene(){}
    }
}