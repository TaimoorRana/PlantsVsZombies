using UnityEngine;
using System.Collections;

public class Peas : MonoBehaviour {
	int damage = 100;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(2,0);
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if(col != null && col.gameObject.tag == "Enemy"){
			Zombie zombie = col.gameObject.GetComponent<Zombie>();
			zombie.takeDamage(damage);
			Destroy(this.gameObject);
			print("peas Collisison");
		}

	}
}
