using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(KeyCode.Alpha1)) 
		{
            Fabric.EventManager.Instance.PostEvent("DynamicMixer", Fabric.EventAction.AddPreset, "MuteMusic");
		}
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Fabric.EventManager.Instance.PostEvent("DynamicMixer", Fabric.EventAction.RemovePreset, "MuteMusic");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Fabric.EventManager.Instance.PostEvent("DynamicMixer", Fabric.EventAction.AddPreset, "MuteSFX");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Fabric.EventManager.Instance.PostEvent("DynamicMixer", Fabric.EventAction.RemovePreset, "MuteSFX");
        }
	}
}
