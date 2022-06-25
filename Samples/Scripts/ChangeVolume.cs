using UnityEngine;
using System.Collections;

public class ChangeVolume : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Fabric.EventManager.Instance.PostEvent("TestEvent1", gameObject);
		Fabric.EventManager.Instance.PostEvent("TestEvent2", gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Alpha1)) {
			Fabric.EventManager.Instance.PostEvent("TestEvent1", Fabric.EventAction.SetVolume, 1.0f, gameObject);
			Debug.Log ("Change Group Component to volume: 1.0");
		}
		
		else if(Input.GetKeyDown(KeyCode.Alpha2)) {
			Fabric.EventManager.Instance.PostEvent("TestEvent1", Fabric.EventAction.SetVolume, 0.2f, gameObject);
			Debug.Log ("Change Group Component to volume: 0.2");
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha3)) {
			Fabric.EventManager.Instance.PostEvent("TestEvent2", Fabric.EventAction.SetVolume, 1.0f, gameObject);
			Debug.Log ("Change Audio Component to volume: 1.0");
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha4)) {
			Fabric.EventManager.Instance.PostEvent("TestEvent2", Fabric.EventAction.SetVolume, 0.2f, gameObject);
			Debug.Log ("Change Audio Component to volume: 0.2");
		}
		
	}
}
