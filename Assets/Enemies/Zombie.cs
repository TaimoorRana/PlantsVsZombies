using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {
	public int health;
	public int hit;
	public float speed;
	private static int score;
	public static int scoreValue;
	public AudioClip audio1;
	// Use this for initialization
	void Start () {
		scoreValue = 25;
	}
	
	// Update is called once per frame
	void Update () {
		this.rigidbody2D.velocity= new Vector2(speed,0);
	}
	
	public void takeDamage(int damage){
		health -= damage;
		
		if(health <= 0){
			Destroy(this.gameObject);
			score += scoreValue;
			AudioSource.PlayClipAtPoint(audio1,transform.position);
		}
		
		if(score % 500 == 0 && score!= 0){
			health = health * 5;
		}	
	}
	
	public int getHit(){
		return hit;
	}
	
	public static int getScore(){
		return score;
	}
	
	public static void resetScore(){
		score = 0;
	}
}
