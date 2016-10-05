using UnityEngine;
using System.Collections;

public class TrampaControl : MonoBehaviour {
public bool activated;

void Awake ()
	{
		// Start the event listener
		Debug.Log("Empezando listener de trampa");
		ColisionesPersonaje.Instance.ActivateObject += Activate;
		//ColisionesPersonaje c = GameObject.Find("FPSController").transform.GetComponent<ColisionesPersonaje>();
		//c.ActivateObject += ActivateObject;
	}
	


	// Use this for initialization
	void Start () {
		activated = false;
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public Transform esferaMuerte;
	
	void Activate(Collider obj){
		Debug.Log("Se ha activado la colision con la trampa");
		if (obj.gameObject.name.Equals(gameObject.transform.name)){
			if (activated == false){
				activated = true;
				for (int i = 0; i < 3; i++){
					Instantiate(esferaMuerte, new Vector3(-9 + i*2, 8 + i*2, 47), Quaternion.identity);
				}
				 
			}
		}
	}
}
