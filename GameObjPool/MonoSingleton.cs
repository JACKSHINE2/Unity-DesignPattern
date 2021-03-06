﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class MonoSingleton<T> : MonoBehaviour
where T:Component
{
    private static T t;
    public static T instance
    {
        get
        {
            t = GameObject.FindObjectOfType(typeof(T)) as T;
            if (t == null)
            {
                GameObject go = new GameObject();
                t = go.AddComponent<T>();

            }
            DontDestroyOnLoad(t.gameObject);

            return t;
        }
    }
    //public void Start()
    //{
    //    Init();
    //}
    //public virtual void Init() {

    //}
   
	
}
