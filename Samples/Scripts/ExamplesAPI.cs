using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExamplesAPI : MonoBehaviour 
{
    public int eventID;

	// Use this for initialization
	void Start () {}

    public GameObject _go;

	// Update is called once per frame
	void Update () 
	{
		// Example 1: Posting an event
		if(Input.GetKeyDown(KeyCode.Alpha1)) 
		{
			/////////////////////////////////////////////////////////////
			// This event by default will send the PlaySound EventAction.
			// The gameObject used is the one that has the FabricManager
           
            Fabric.EventManager.Instance.PostEvent("Simple");
		}
		// Example 2: Posting an event with a gameObject
		else if(Input.GetKeyDown(KeyCode.Alpha2)) 
		{
			/////////////////////////////////////////////////////////////
			// This event by default will send the PlaySound EventAction.
			// The gameObject passed is used to track position and associated with an instance if max instances property is set
			
			Fabric.EventManager.Instance.PostEvent("Simple", gameObject);
		}
		// Example 3: Posting an event with a PlaySound action and a gameObject
		else if(Input.GetKeyDown(KeyCode.Alpha3)) 
		{
			Fabric.EventManager.Instance.PostEvent("Simple", Fabric.EventAction.PlaySound, null, gameObject);
		}
		// Example 4: Posting a stop sound event action
		else if(Input.GetKeyDown(KeyCode.Alpha4)) 
		{
			Fabric.EventManager.Instance.PostEvent("Simple", Fabric.EventAction.StopSound, null, gameObject);
		}
		// Example 5: Posting a timeline SetParameter value
		else if(Input.GetKeyDown(KeyCode.Alpha5)) 
		{
			Fabric.EventManager.Instance.SetParameter("Timeline", "Parameter", 0.5f, gameObject);
		}
		// Example 6: Posting a SetDSPParameter value
		else if(Input.GetKeyDown(KeyCode.Alpha6)) 
		{
			Fabric.EventManager.Instance.SetDSPParameter("Event", Fabric.DSPType.LowPass, "CutoffFrequency", 5000, 5, 0.5f, gameObject);
		}
		// Example 7: Adding dynamic mixer preset
		else if(Input.GetKeyDown(KeyCode.Alpha7)) 
		{
			// The event name must be "DynamicMixer"
			Fabric.EventManager.Instance.PostEvent ( "DynamicMixer", Fabric.EventAction.AddPreset, "MuteAll", null ) ;
		}
		// Example 8: Removing dynamic mixer preset
		else if(Input.GetKeyDown(KeyCode.Alpha8)) 
		{
			// The event name must be "DynamicMixer"
			Fabric.EventManager.Instance.PostEvent ( "DynamicMixer", Fabric.EventAction.RemovePreset, "MuteAll", null ) ;
		}       
		// Example 9: Get component by name, setting volume, querying if component is playing and if not play it
		else if(Input.GetKeyDown(KeyCode.Alpha9))
		{
			Fabric.Component component = Fabric.FabricManager.Instance.GetComponentByName("Audio_Fabric_SFX_Test");
		
			if(component != null)
			{
				component.Volume = 0.5f;
				
				if(component.IsPlaying() == false)
				{
					component.Play(gameObject);
				}
			}
		}
		// Loading prefab that has Fabric components into the Fabric hiearchy with a target path
		else if(Input.GetKeyDown(KeyCode.A))
		{
			Fabric.FabricManager.Instance.LoadAsset("NameOfPrefab","Audio_SFX");
		}
		// Unloading component from the Fabric hiearchy
		else if(Input.GetKeyDown(KeyCode.B))
		{
			Fabric.FabricManager.Instance.UnloadAsset("Audio_SFX");
		}
		// Initialise default component parameters (ideal for setting parameters in animation systems) 
		else if(Input.GetKeyDown(KeyCode.C)) 
		{
			Fabric.InitialiseParameters parameters = new Fabric.InitialiseParameters();
			
			parameters._pitch.Value = 2.0f;
				
			Fabric.EventManager.Instance.PostEvent("Simple",Fabric.EventAction.PlaySound, null, gameObject, parameters);
		}
        // Check if an event is playing
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (Fabric.EventManager.Instance.IsEventActive("Simple", gameObject))
            {
                Debug.Log("Event Simple is Active");
            }
            else
            {
                Debug.Log("Event Simple is Inactive");
            }
        }
		else if(Input.GetKeyDown(KeyCode.E))
		{
			Fabric.Component[] components = Fabric.FabricManager.Instance.GetComponentsByName("Audio_Simple", gameObject);
		
			if(components != null && components.Length> 0)
			{
				components[0].Volume = 0.5f;
				
				if(components[0].IsPlaying() == true)
				{
					Debug.Log("Component is playing");
				}
			}
		}
        if (Input.GetKeyDown(KeyCode.G))
        {
            eventID = Fabric.EventManager.GetIDFromEventName("Simple");
            Fabric.EventManager.Instance.PostEvent(eventID, gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            Fabric.EventManager.Instance.PostEvent("Simple", Fabric.EventAction.SetAudioClipReference, "DialogLine", gameObject);
        }
    }
}
