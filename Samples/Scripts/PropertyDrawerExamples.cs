using UnityEngine;
using System.Collections;

public class PropertyDrawerExamples : MonoBehaviour {

    [Fabric.FabricEventAttribute]
    public string testSoundEvent;

    [Fabric.DecibelsSliderAttribute]
    public float volume;

    void Update()
    {
        
    }
}
