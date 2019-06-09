using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UIFramework
{
    public class EventAction
    {
        //事件委托
        public delegate void MessageHandler(object[] args);

        //注册/移除事件委托
        public delegate void HandlerMsg(string name,MessageHandler msg);

        //通过事件委托
        public delegate void MessageNotify(string name,object[] args);


    }


}

