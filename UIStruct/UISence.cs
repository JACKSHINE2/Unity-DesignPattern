using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 管理所有的UI子物体
/// </summary>
public class UISence : MonoBehaviour {
    /// <summary>
    /// 管理所有组件容器
    /// </summary>
    public Dictionary<string, UIEventTrigger>
        uiTransDic = new Dictionary<string, UIEventTrigger>();

    public void Start()
    {
        Init();
    }
    /// <summary>
    /// 初始化所有需要被管理的子控件
    /// </summary>
    public void Init()
    {
        int tChildCount = transform.childCount;
        UIEventTrigger trigger;
        for (int i = 0; i < tChildCount; i++)
        {
            trigger = transform.GetChild(i)
                .GetComponent<UIEventTrigger>();
            if (trigger != null)
                uiTransDic.Add(trigger.gameObject.name,
                    trigger);
        }
    }
    /// <summary>
    /// 获取子物体
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public UIEventTrigger GetChild(string name)
    {
        if (uiTransDic.ContainsKey(name))
            return uiTransDic[name];
        return null;
    }
    public T GetChild<T>(string name) where T : Component
    {
      UIEventTrigger go=  GetChild(name);

        if (go == null) return null;
        T t = go.GetComponent<T>();
        if (t != null)
            return t;
        return null;
        
    }
    /// <summary>
    /// 获取子物体
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public Transform FindChild(string name)
    {
        return SceneHelper.FindChild(this.transform, name);
    }
    public T FindChild<T>(string name) where T : Component
    {
        return SceneHelper.FindChild<T>(this.transform, name);
    }
}
public class SceneHelper
{
    public static Transform FindChild(Transform item,string name)
    {
        Transform t = null;
        t = item.Find(name);
        if (t != null) return t;
        for (int i = 0; i < item.childCount; i++)
        {
            t = FindChild(item.GetChild(i),name);
            if (t != null)
                return t;
        }
        return null;
    }


    public static T FindChild<T>(Transform item, string name)
        where T : Component
    {
        Transform t = null;
        t = item.Find(name);
        if (t != null) return t.GetComponent<T>();
        for (int i = 0; i < item.childCount; i++)
        {
            t = FindChild(item.GetChild(i), name);
            if (t != null)
                return t.GetComponent<T>();
        }
        return null;
    }

}
