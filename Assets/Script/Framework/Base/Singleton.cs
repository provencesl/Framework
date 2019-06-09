using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 为什么需要单例：
/// 1）游戏啊开始和结束前需要进行操作：
/// 如网络连接和断开，资源加载和卸载，这些逻辑放在单例中
/// 2）单例可以控制初始化和销毁顺序，但是静态变量和场景中的GameObject无法控制自己的
/// 创建和销毁顺序，这就造成了很大问题
/// 3）GameObject需要动态创建，而不是固定在场景中
/// 4）场景中的GameObject需要从单例中存取数据
/// 
/// 
/// 管理类必须存在诸多场景，并且在加载场景时不能销毁。
/// 
/// 
/// 
/// 避免延迟初始化，
/// 1)需避免多线程创建单例带来的复杂度
/// 2)在某处定义的一定初始化顺序后，可以在游戏结束时按照相反顺序销毁单例
/// 
/// 没有加锁的泛型单例模式
/// 
/// </summary>
/// <typeparam name="T">约束必须为Monobehaviour</typeparam>
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

    //单例
    private static T _instance;

    public static T GetInstance()
    {
        if (_instance == null)
        {
            //在已存在的脚本中查找单例
            _instance = (T)FindObjectOfType(typeof(T));
            if (_instance == null)
            { new GameObject(typeof(T).Name).AddComponent<T>(); }
        }
        return _instance;
    }


    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;

        }
        else if(_instance != this)
         {
            if (_instance.gameObject != gameObject)
            {
                Destroy(gameObject);
            }
            else
            {
                Destroy(this);
            }
           
          }
    }

    protected virtual void OnDestroy()
    {
        if (_instance == this) _instance = null;
    }


    protected virtual void Init(){ }



}
