using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIFramework
{
    /// <summary>
    /// UI窗口生命周期管理
    /// </summary>
    public interface IUILife
    {
        GameObject GetGameObject { get; }

        /// <summary>
        /// 窗口初始化使用
        /// </summary>
        void OnInit();

        /// <summary>
        /// 窗口每次显示后调用
        /// </summary>
        void OnBeforeShow();

        /// <summary>
        /// 窗口每次显示后调用
        /// </summary>
        void OnShow();

        /// <summary>
        /// 窗口每帧渲染
        /// </summary>
        void OnUpdate();

        /// <summary>
        /// 窗口销毁调用
        /// </summary>
        void OnDestroy();


    }
}


