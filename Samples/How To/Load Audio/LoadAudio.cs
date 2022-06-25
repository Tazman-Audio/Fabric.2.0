using UnityEngine;
using System.Collections;

public class LoadAudio : MonoBehaviour 
{
    // Use this for initialization
    void Start ()
    {
        //
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Fabric.EventManager.Instance.PostEvent("Simple", gameObject);
            Fabric.EventManager.Instance.PostEvent("Simple", Fabric.EventAction.LoadAudio, null, gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Fabric.EventManager.Instance.PostEvent("Simple", Fabric.EventAction.StopSound, null, gameObject);
            Fabric.EventManager.Instance.PostEvent("Simple", Fabric.EventAction.UnloadAudio, null, gameObject);
        }
    }
}
