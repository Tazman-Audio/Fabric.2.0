using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Fabric.EventManager.Instance.PostEvent("AlertArea", Fabric.EventAction.SetSwitch, "pooo", gameObject);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
