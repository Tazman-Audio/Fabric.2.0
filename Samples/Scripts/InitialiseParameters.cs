using UnityEngine;
using System.Collections;

public class InitialiseParameters : MonoBehaviour {
	
	Fabric.InitialiseParameters parameters = new Fabric.InitialiseParameters();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	    if(Input.GetKeyDown(KeyCode.Alpha1)) 
	    {
		    //parameters._delaySamples.Value = 50000;

            parameters._isMutliplier = true;
            parameters._volume.Value = 0.5f;
			
		    Fabric.EventManager.Instance.PostEvent("Simple",Fabric.EventAction.PlaySound, null, gameObject, parameters);
	    }
	
	}
}
