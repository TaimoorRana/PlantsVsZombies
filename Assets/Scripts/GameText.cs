using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameText : MonoBehaviour {
	// Use this for initialization
	Text text;
	void Start () {
		text = (Text)this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = Zombie.getScore().ToString();
	}
}
