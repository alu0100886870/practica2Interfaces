using UnityEngine;
using System.Collections;

public class GemaControl : MonoBehaviour {
public bool activated;

void Awake ()
	{
		// Start the event listener
		Debug.Log("Empezando listener!");
		ColisionesPersonaje.Instance.ActivateObject += Activate;
		//ColisionesPersonaje c = GameObject.Find("FPSController").transform.GetComponent<ColisionesPersonaje>();
		//c.ActivateObject += ActivateObject;
	}
	


	// Use this for initialization
	void Start () {
	GetComponent<Light>().intensity = 0;
		activated = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (activated == true){
			transform.Rotate(0, 10, 0);
			GetComponent<Light>().intensity = 8;
		}
	}
	
	
		void Activate(Collider obj){
		if (obj.gameObject.name.Contains("GemaV")){
		activated = true;
			Debug.Log("Collisionado con la gema DESDE LA GEMA");
		}
	}
}
