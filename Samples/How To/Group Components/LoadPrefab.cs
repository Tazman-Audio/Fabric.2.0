using UnityEngine;
using System.Collections;

public class LoadPrefab : MonoBehaviour 
{
    public string _externalGroupComponent;
    public string _groupComponent;

    GameObject instance = null;

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
            GameObject audioPrefab = Resources.Load(_groupComponent) as GameObject;

            if (audioPrefab != null)
            {
                GameObject.DestroyImmediate(instance);

                instance = GameObject.Instantiate(audioPrefab);

                Fabric.EventManager.Instance.PostEvent("Group Component");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject audioPrefab = Resources.Load(_externalGroupComponent) as GameObject;

            if (audioPrefab != null)
            {
                GameObject.DestroyImmediate(instance);

                instance = GameObject.Instantiate(audioPrefab);

                Fabric.EventManager.Instance.PostEvent("Components A");
                Fabric.EventManager.Instance.PostEvent("Components B");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameObject.DestroyImmediate(instance);            
        }
    }
}
