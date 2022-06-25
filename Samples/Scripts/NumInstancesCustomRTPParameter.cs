using UnityEngine;
using System.Collections;

public class NumInstancesCustomRTPParameter : MonoBehaviour, Fabric.ICustomRTPParameter
{
    void Start()
    {
        Fabric.FabricManager.Instance._customRTPParameter = this;
    }
    float Fabric.ICustomRTPParameter.UpdateProperty(Fabric.Component instance, Fabric.RTPProperty property, Fabric.RTPPropertyType type)
    {
        if (instance.ComponentHolder != null)
        {
            return (float)instance.ComponentHolder.GetNumActiveComponentInstances() / instance.MaxInstances;
        }

        return 0.0f;
    }
}
