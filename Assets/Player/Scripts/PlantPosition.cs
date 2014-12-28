using UnityEngine;
using System.Collections;

public class PlantPosition : MonoBehaviour {
	public GameObject plantSpawner;
	private int totalPlants = 0;
	private bool zombieEntered = false;
	
	// Use this for initialization
	void Start () {
		plantSpawner = (GameObject)GameObject.Find("PlantSpawner");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){
		if(totalPlants <= 1 && zombieEntered == false ){
			bool result = plantSpawner.GetComponent<PlantSpawner>().SpawnHere(transform.position);
			if(result == true){
				totalPlants = totalPlants + 1;
			}
		}
	}
	
	void OnTriggerStay2D(Collider2D col){
			zombieEntered = false;			
		if(col != null && col.gameObject.tag == "Enemy"){
			zombieEntered = true;
		}
	}
	
	void resetPlant(){
		totalPlants = 0;
	}
}
