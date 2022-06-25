using UnityEngine;
using System.Collections;

public class OnEventNotify : MonoBehaviour
{

    [SerializeField]
    public Fabric.AudioComponent component;

    public string _eventName;

    // Use this for initialization
    void Start()
    {

        Fabric.EventManager.Instance.PostEventNotify(_eventName, gameObject, Notify);

        // NOTE: Overriding the event notification at the component level overwrites the event notfication 
        //       used in the PostEvent function
        if (component)
        {
            component._onEventNotify += NotifyOnFinished;
        }
    }

    public void NotifyOnFinished(Fabric.EventNotificationType type, string eventName, object info, GameObject gameObjec)
    {
        if (component && gameObject && type == Fabric.EventNotificationType.OnFinished)
        {
            Debug.Log("OnNotify:" + type + "GameObject:" + gameObject.name);
        }
    }

    public void Notify(Fabric.EventNotificationType type, string eventName, object info, GameObject gameObject)
    {
        Debug.Log("OnNotify: " + type + " - EventName: " + eventName + " - GameObject: " + ((gameObject != null) ? gameObject.name : ""));

        if (info != null)
        {
            if (type == Fabric.EventNotificationType.OnSequenceAdvance)
            {
                Fabric.Component c = info as Fabric.Component;

                if (c != null)
                {
                    Debug.Log("Info: " + c.name);
                }
            }
            else if (type == Fabric.EventNotificationType.OnMarker)
            {
                Fabric.MarkerNotficationData c = info as Fabric.MarkerNotficationData;

                if (c != null)
                {
                    Debug.Log("Offset: " + c._offset + " - Label: " + c._label);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Fabric.EventManager.Instance.PostEventNotify(_eventName, gameObject, Notify);
        }
    }
}
