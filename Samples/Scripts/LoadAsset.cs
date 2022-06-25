using UnityEngine;
using System.Collections;

public class LoadAsset : MonoBehaviour {
	
    public string asset;
    public string prefabLocation;
    public string targetComponent;
    public bool loadAsset=false;
	public bool unloadAsset=false;
		
	void Update () {
		
		if(loadAsset)
		{
            Fabric.FabricManager.Instance.LoadAsset(prefabLocation + "/" + asset, targetComponent);
			loadAsset=false;
		}
		
		if(unloadAsset)
		{
			Fabric.FabricManager.Instance.UnloadAsset(targetComponent + "_" + asset);
			unloadAsset=false;
		}
	}
}