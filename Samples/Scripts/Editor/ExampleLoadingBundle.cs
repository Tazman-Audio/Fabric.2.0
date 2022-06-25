using UnityEngine;
using System.Collections;

public class ExampleLoadingBundle : MonoBehaviour
{
    public string url = "http://www.mygame.com/myBundle.unity3d"; // URL where the AssetBundle is
    public int version = 1; // The version of the AssetBundle

    public string assetName = "MyPrefab"; // Name of the Asset to be loaded from the AssetBundle
    public string assetPath; // Path to the Asset in the Project folder

    private Object ObjInstance; // Instance of the object
    void Start()
    {
        StartCoroutine(Download());
    }

    IEnumerator Download()
    {
        AssetBundleLoader assetBundleLoader = new AssetBundleLoader();
        yield return StartCoroutine(assetBundleLoader.LoadBundle<GameObject>(url, version, assetName, assetPath));
        if (assetBundleLoader.Obj != null)
            ObjInstance = Instantiate(assetBundleLoader.Obj);
    }

    void OnGUI()
    {
        GUILayout.Label(ObjInstance ? ObjInstance.name + " instantiated" : "");
    }
}