using UnityEngine;
using System.Collections;

public class StopAll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        // Stop only instances that started with this game object
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
		{
            Fabric.Component[] components = Fabric.FabricManager.Instance.GetComponentsByName("Audio_Group", gameObject);


           for (int i = 0; i < components.Length; i++)
            {
                components[i].Stop();
            }
		}
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Fabric.Component component = Fabric.FabricManager.Instance.GetComponentByName("Audio_Group") as Fabric.Component;

            if (component != null)
            {
                component.Stop(true, false);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Fabric.FabricManager.Instance.Stop(0.5f);
        }
    }
}
