using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseGameObjectPool : MonoBehaviour {

    public GameObject cube;
    public GameObject item;
	// Use this for initialization
	void Start () {
		
	}
    GameObject go=null;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            go= GameObjectPool.instance.CreateObject(cube.name,cube,
                null, Vector3.zero, transform.rotation);
            GameObjectPool.instance.MyDestory(go, 3);
        }
        if (Input.GetMouseButtonDown(1))
            GameObjectPool.instance.CreateObject(cube.name, cube,
                null, new Vector3(10,10,10), transform.rotation);
    }
}
