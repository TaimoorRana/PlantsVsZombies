using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {
	Text text;
	// Use this for initialization
	void Start () {
		text = (Text)GameObject.Find("Score").GetComponent<Text>();
		text.text += Zombie.getScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
