using UnityEngine;
using System.Collections;

public class LoadAudioPrefab : MonoBehaviour 
{
    public string _audioPrefabName = "Audio";

	// Use this for initialization
	void Start ()
    {
        GameObject audioPrefab = GameObject.Find("Audio");
        if (audioPrefab == null)
        {
            // Load audio prefab
            audioPrefab = Resources.Load(_audioPrefabName) as GameObject;

            if (audioPrefab != null)
            {
                // Instantiate audio prefab
                GameObject.Instantiate(audioPrefab);
            }
            else
            {
                Debug.LogError("Audio prefab not available");
            }
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
	    //
	}
}
