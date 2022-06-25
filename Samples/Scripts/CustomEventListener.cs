using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CustomEventListener : MonoBehaviour, Fabric.IEventListener
{
    public string _eventName = "";

    void Awake()
    {
        Fabric.EventManager.Instance.RegisterListener(this as Fabric.IEventListener, _eventName);
    }

    Fabric.EventStatus Fabric.IEventListener.Process(Fabric.Event zEvent)
    {
        Fabric.EventStatus result = Fabric.EventStatus.Not_Handled;

        switch (zEvent.EventAction)
        {
            case Fabric.EventAction.PlaySound:
                {
                    Fabric.EventTrigger eventTrigger = gameObject.GetComponent<Fabric.EventTrigger>();

                    if (eventTrigger != null)
                    {
                        eventTrigger.PostEvent();
                    }

                    result = Fabric.EventStatus.Handled;
                }
                break;
        }

        return result;
    }

    bool Fabric.IEventListener.IsActive(GameObject parentGameObject)
    {
        return false;
    }

    bool Fabric.IEventListener.IsDestroyed
    {
        get { return this == null; }
    }

    bool Fabric.IEventListener.GetEventListeners(string eventName, List<Fabric.EventListener> listeners)
    {
        return false;
    }

    bool Fabric.IEventListener.GetEventListeners(int eventID, List<Fabric.EventListener> listeners)
    {
        return false;
    }

    bool Fabric.IEventListener.GetEventInfo(GameObject parentGameObject, ref Fabric.EventInfo eventInfo)
    {
        return false;
    }
}
