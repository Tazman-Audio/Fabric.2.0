using UnityEngine;
using System.Collections;

public class CustomRTPParameter : MonoBehaviour, Fabric.ICustomRTPParameter
{
    void Start()
    {
        Fabric.FabricManager.Instance._customRTPParameter = this;
    }

    float Fabric.ICustomRTPParameter.UpdateProperty(Fabric.Component instance, Fabric.RTPProperty property, Fabric.RTPPropertyType type)
    {
        float value = 1.0f;

        if ((Fabric.Component.RTPPropertyEnum)property._property == Fabric.Component.RTPPropertyEnum.Volume)
        {
            value = 0.707f;
        }
        else if ((Fabric.Component.RTPPropertyEnum)property._property == Fabric.Component.RTPPropertyEnum.Pan2D)
        {
            value = -1.0f;
        }

        return value;
    }
}
