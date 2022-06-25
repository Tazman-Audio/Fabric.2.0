using UnityEngine;
using System.Collections;

public class GetComponentByName : MonoBehaviour {
	
	Fabric.AudioComponent component = null;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(component == null)
		{
			component = Fabric.FabricManager.Instance.GetComponentByName("Audio_Fabric_SFX_Test") as Fabric.AudioComponent;
			
			component.Volume = 0.0f;
		}
	}
}
