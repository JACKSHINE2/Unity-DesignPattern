using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 所有UIPanel的管理  
/// </summary>
public class UIManager : MonoSingleton<UIManager> {

    //获取到所有的UIPanle  UIScene
    Dictionary<string, UISence> uiScenes = new Dictionary<string, UISence>();

  
    /// <summary>
    /// 初始化
    /// </summary>
    public void Init()
    {
        object[] uiScene = GameObject.
            FindObjectsOfType(typeof(UISence));
        UISence item=null;
        //tem = this.gameObject;
       // print(item.name);
        for (int i = 0; i < uiScene.Length; i++)
        {
        
            item = (UISence)uiScene[i];
           // print(item.name);
            if (!uiScenes.ContainsKey(item.name))
            {
                uiScenes.Add(item.name,
                item);
            }
            item.gameObject.SetActive(false);
        }
    }
    /// <summary>
    /// 显示一级界面
    /// </summary>
    public void ShowUI()
    {
        //打开   关闭
        OpenUiScene(UISenceName.Panel_Main, true);
    }
    /// <summary>
    /// 打开或者关闭界面
    /// </summary>
    /// <param name="name">要打开/关闭的界面名称</param>
    /// <param name="isSceneOpen">打开或者关闭</param>
    public void OpenUiScene(string name,bool isSceneOpen)
    {
        if(uiScenes.ContainsKey(name))
        {
            uiScenes[name].
                gameObject.SetActive(isSceneOpen);

        }
    }
}
public class UISenceName
{
    public const string Panel_Main = "Panel_Main";
    public const string Panel_OpenScene = "Panel_OpenScene";

}
