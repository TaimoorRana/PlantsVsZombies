﻿using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {
	public LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D (Collider2D col){
			Destroy(col.gameObject);
			if(col.gameObject.tag == "Enemy"){
				levelManager.LoadLevel("Win Screen");			
			}
	}
}
