using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UISceneMain : UISence {

    private UIEventTrigger mButton1;
    private UIEventTrigger mButton2;
    private UIEventTrigger mButton3;
    private UIEventTrigger mButton4;
    private UIEventTrigger mButton5;
    private UIEventTrigger mButton6;
    private UIEventTrigger mButton7;
    private UIEventTrigger mButton8;


    // Use this for initialization
    void Start () {
        base.Start();
        switch (transform.name)
        {
            case "main":
                {
                    mButton1 = GetChild("regButton");
                    mButton1.onClick += MButton_Open_onClick1;
                    mButton5 = GetChild("home");
                    mButton5.onClick += MButton_Open_onClick5;                    
                    break;
                }
            case "reg":
                {
                    mButton2 = GetChild("regSure");
                    mButton2.onClick += MButton_Open_onClick2;

                    mButton3 = GetChild("regOff");
                    mButton3.onClick += MButton_Open_onClick3;
                    break;
                }
            case "warning":
                {
                    mButton4 = GetChild("Sure");
                    mButton4.onClick += MButton_Open_onClick4;
                    break;
                }
            case "login":
                {
                    mButton6 = GetChild("loginBtn");
                    mButton6.onClick += MButton_Open_onClick6;
                    break;
                }
            case "create":
                {
                    mButton7 = GetChild("creBtn");
                    mButton7.onClick += MButton_Open_onClick7;
                    break;
                }
            case "waiting":
                {
                    mButton8 = GetChild("wait");
                    mButton8.onClick += MButton_Open_onClick8;                    
                    break;
                }
           


        }

        
        
        
        
        



    }

    private void MButton_Open_onClick1()
    {
        UIManager.instance.OpenUiScene(UISenceName.reg, true);
        UIManager.instance.OpenUiScene(UISenceName.login, false);
    }

    private void MButton_Open_onClick2()
    {
        UIManager.instance.OpenUiScene (UISenceName.reg, false);
        UIManager.instance.OpenUiScene (UISenceName.login, true);
    }

    private void MButton_Open_onClick3()
    {
        UIManager.instance.OpenUiScene(UISenceName.reg, false);
        UIManager.instance.OpenUiScene(UISenceName.login, true);

    }
    private void MButton_Open_onClick4()
    {
        UIManager.instance.OpenUiScene(UISenceName.warning, false);
        UIManager.instance.OpenUiScene(UISenceName.login, true);
    }
    private void MButton_Open_onClick5()
    {
        UIManager.instance.OpenUiScene(UISenceName.warning, true);
        UIManager.instance.OpenUiScene(UISenceName.login, false);
    }
    private void MButton_Open_onClick6()
    {
        SceneManager.LoadScene(0);
    }
    private void MButton_Open_onClick7()
    {
        SceneManager.LoadScene(1);
    }
    private void MButton_Open_onClick8()
    {
        UIManager.instance.OpenUiScene("create", true);
        UIManager.instance.OpenUiScene("waiting", false);
    }
    




    // Update is called once per frame
    void Update () {
		
	}
}
