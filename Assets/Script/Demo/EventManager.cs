using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// 事件（消息）管理器
/// 1）事件类型的枚举
/// 2）事件列表
/// 3）监听器的添加和删除
/// 4）事件发送
/// 
/// 原理：
/// 每个消息触发时，在触发位置需要调用事件发送的函数，然后
/// 函数会去事件列表中定位事件，找出它对应的回调函数队列，逐个执行。
/// 如果没有回调函数，那么这个消息什么也不做。如果某个类需要监听时间，
/// 则将回调函数注册进去。不需要就删除。
/// 
/// 使用delegate作为参数
/// 
/// 
/// 1.事件订阅（AddListener）:用户将做的事添加到事件系统
/// 2.事件分发（Invoke）:框架在特定时刻分发以触发指定类型事件
/// 3.移除事件（RemoveListener）:用户移除额定事件
/// </summary>
public class EventManager : Singleton<EventManager> {

    //使用dic管理需要监听的事件
    private Dictionary<string, UnityEvent> dic;
    private static EventManager _instance;
    public static EventManager Instance
    {
        get
        {
            //如果instance为空
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(EventManager)) as EventManager;
                if (!_instance)
                {
                    Debug.Log("");
                }
                else
                {
                    _instance.Init();
                }

            }
            return _instance;
        }
    }

    void Init()
    {
        if (dic == null)
        {
            dic = new Dictionary<string, UnityEvent>();
        }
    }

    //监听事件
    public static void StartListening(string eventName, UnityAction listener)
    {
        UnityEvent thisEvent = null;
        if (_instance.dic.TryGetValue(eventName, out thisEvent))
        {

        }

    }



}
