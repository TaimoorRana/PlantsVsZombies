using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void LoadLevel(string name) {
		if(name == "Game"){
			Zombie.resetScore();
		}
		Debug.Log("New Level Load: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log("quiting");
		Application.Quit();
	}
	
	
}
