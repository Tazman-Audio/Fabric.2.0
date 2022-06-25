using UnityEngine;
using System.Collections;

public class AssetBundleLoader
{
    public Object Obj; // The object retrieved from the AssetBundle

    public IEnumerator LoadBundle<T>(string url, int version, string assetName, string assetPath) where T : Object
    {
        Obj = null;

        //#if UNITY_EDITOR
        Obj = UnityEditor.AssetDatabase.LoadAssetAtPath(assetPath, typeof(T));
        if (Obj == null)
            Debug.LogError("Asset not found at path: " + assetPath);
        yield break;

        //#else

        //WWW download;
        //if (Caching.enabled)
        //{
        //    while (!Caching.ready)
        //        yield return null;
        //    download = WWW.LoadFromCacheOrDownload(url, version);
        //}
        //else
        //{
        //    download = new WWW(url);
        //}

        //yield return download;
        //if (download.error != null)
        //{
        //    Debug.LogError(download.error);
        //    download.Dispose();
        //    yield break;
        //}

        //AssetBundle assetBundle = download.assetBundle;
        //download.Dispose();
        //download = null;

        //if (assetName == "" || assetName == null)
        //    Obj = assetBundle.mainAsset;
        //else
        //    Obj = assetBundle.Load(assetName, typeof(T));

        //assetBundle.Unload(false);

        //#endif
    }
}

//using UnityEngine;
//using System.Collections;

//public class LoadAssetBundle : MonoBehaviour
//{
//    IEnumerator Load()
//    {
//        WWW www = new WWW("AssetBundles/english");

//        //Here we need to yield to make sure Www has loaded some of the audio data otherwise we miss a chunk when isStreaming is true
//        while (www.isDone == false)// && www.progress < 1.0f)
//        {
//            yield return new WaitForSeconds(0.1f);
//        }

//        AssetBundle bundle = www.assetBundle;

//        Fabric.FabricManager.Instance.SetLanguageAssetBundle("English", bundle);
//    }

//    void Start()
//    {
//        //StartCoroutine(Load());
//        LoadFromResource();
//    }


//    TextAsset fileAsText;

//    void LoadFromResource()
//    {
//        fileAsText = Resources.Load("english") as TextAsset;
//        if (fileAsText != null)
//        {
//            byte[] bundleData = fileAsText.bytes.Clone() as byte[];
//            AssetBundleCreateRequest bundleRequest = AssetBundle.CreateFromMemory(bundleData);

//            Fabric.FabricManager.Instance.SetLanguageAssetBundle("English", bundleRequest.assetBundle);
//        }
//    }

//    //IEnumerator Load()
//    //{
//    //    WWW www = new WWW(filePath);

//    //    yield return www;

//    //    // Load and retrieve the AssetBundle
//    //    AssetBundle bundle = www.assetBundle;

//    //    Fabric.FabricManager.Instance.SetLanguageAssetBundle("English", bundle);

//    //    // Load the object asynchronously
//    //    //AssetBundleRequest request = bundle.LoadAssetAsync("Beat.wav", typeof(GameObject));

//    //    // Wait for completion
//    //    //yield return request;

//    //    // Get the reference to the loaded object
//    //    //GameObject obj = request.asset as GameObject;

//    //    // Unload the AssetBundles compressed contents to conserve memory
//    //    //bundle.Unload(false);

//    //    // Frees the memory from the web stream
//    //    //www.Dispose();
//    //}
//}