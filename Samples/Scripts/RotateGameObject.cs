using UnityEngine;
using System.Collections;

public class RotateGameObject : MonoBehaviour {

    public float _rotSpeed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
            transform.Rotate(0, _rotSpeed * Time.deltaTime, 0, Space.World);
	}
}
