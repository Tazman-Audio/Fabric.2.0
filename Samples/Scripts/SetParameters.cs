using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SetParameters : MonoBehaviour 
{
    public float value;

	// Use this for initialization
	void Start () 
    {
        Fabric.EventManager.Instance.PostEvent("Simple", Fabric.EventAction.PlaySound, null, gameObject);
    }
	
	// Update is called once per frame
	void Update () 
	{
        //Fabric.EventManager.Instance.SetParameter("Simple", "rpm", value, gameObject);

        Fabric.EventManager.Instance.SetParameter("Simple", 0, value, gameObject);

        //Fabric.EventManager.Instance.SetParameter("Simple".GetHashCode(), 0, value, gameObject);

        //Fabric.EventManager.Instance.SetParameter("Simple", "rpm", value, gameObject);
        //Fabric.EventManager.Instance.SetDSPParameter("Event", Fabric.DSPType.LowPass, "CutoffFrequency", 5000, 5, 0.5f, gameObject);
		
    }
}
