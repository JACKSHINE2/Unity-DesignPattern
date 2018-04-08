using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInit : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UIManager.instance.Init();
        UIManager.instance.ShowUI();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
