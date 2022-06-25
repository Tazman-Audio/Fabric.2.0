using UnityEngine;
using System.Collections;

public class AddRemovePreset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Alpha1)) 
		{
			Fabric.EventManager.Instance.PostEvent ( "DynamicMixer", Fabric.EventAction.AddPreset, "MuteAll", null ) ;
			Debug.Log ("Event: Add Preset");
		}

		if(Input.GetKeyDown(KeyCode.Alpha2)) 
		{
			Fabric.EventManager.Instance.PostEvent ( "DynamicMixer", Fabric.EventAction.RemovePreset, "MuteAll", null ) ;
			Debug.Log ("Event: Remove Preset");
		}

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Fabric.GetDynamicMixer.Instance().SwitchPreset("Menu", "MuteAll");
            Debug.Log("Switch Preset");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Fabric.GetDynamicMixer.Instance().SwitchPreset("MuteAll", "Menu");
            Debug.Log("Switch Preset");
        }
	}
}
