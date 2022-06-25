using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SetGameObject : MonoBehaviour 
{
    public GameObject _gameObject;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Alpha1)) 
		{
            Fabric.EventManager.Instance.PostEvent("Simple", Fabric.EventAction.SetGameObject, _gameObject);
		}
		else if(Input.GetKeyDown(KeyCode.Alpha2)) 
		{
			Fabric.EventManager.Instance.PostEvent("Simple", null);
		}
    }
}
