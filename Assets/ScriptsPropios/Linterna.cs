using UnityEngine;
using System.Collections;

public class Linterna : MonoBehaviour {

public Transform Camera;
public Transform parent;
public Transform luz;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = parent.position;
		transform.rotation = parent.rotation;
		//transform.LookAt(Camera.transform);
		//luz.localEulerAngles = new Vector3(180, 180, 180);
	}
}
