using UnityEngine;
using System.Collections;

public class ColisionesPersonaje : MonoBehaviour {

	public delegate void OnSoftCollisionEvent(Collider arg);
	public event OnSoftCollisionEvent ActivateObject;

	// Singleton 	
    private  static ColisionesPersonaje instance; 

	public static ColisionesPersonaje Instance 	
    { 		
        get 		
        { 			
            if (instance ==  null)
                instance = GameObject.FindObjectOfType(typeof(ColisionesPersonaje)) as  ColisionesPersonaje; 
				Debug.Log("Instance vale: " + instance);				
                return instance; 		
        }
	}

	void OnTriggerEnter (Collider other) 
	{ 
		Debug.Log("Collisionado con: " + other);
		if (ActivateObject != null){
			ActivateObject(other);
		}
	}
/*
Debug.Log("Collisionado con: " + other);
    if (other.gameObject.name.Contains("GemaV")) { 
       Debug.Log("Gema tocada");
	   other.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.red;
	   GemaControl script = other.gameObject.transform.GetComponent<GemaControl>();
	   script.activated = true;
   } 
}*/

/*	
void OnCollisionEnter (Collision col)
    {
		Debug.Log("Collisionado con: " + col);
        if(col.gameObject.name == "Emeraldobj1")
        {
            Destroy(col.gameObject);
        }
    }*/
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
}
