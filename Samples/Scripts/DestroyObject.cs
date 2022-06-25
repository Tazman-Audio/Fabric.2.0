using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	public bool destroy = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter()
    {
		DestroyObject(gameObject);
	}
          
	// Update is called once per frame
	void Update () {
	
		if(destroy==true) 
		{
			DestroyObject(gameObject);
			destroy = false;
		}
	}
}
