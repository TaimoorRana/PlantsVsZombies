using UnityEngine;
using System.Collections;

public class Plant : MonoBehaviour {
	public GameObject peasPrefab;
	public int health;
	public float x;
	public float y;
	//float time = 0f;
	// Use this for initialization
	void Start () {
		InvokeRepeating("throwPeas",0.1f,1f);
	}
	
	// Update is called once per frame
	void Update () {
		//time += Time.deltaTime;
		//if(time > 1f){
		//	Start();
		//	time = 0;
		//}
		
	}
	
	void throwPeas(){
		Vector3 peasPosition = transform.position + new Vector3(0.4f,0.7f,0f);
		Instantiate(peasPrefab,peasPosition,Quaternion.identity);
	}
	
	void OnCollisionEnter2D(Collision2D col){
		print ("plant hit by zombie");
		if(col != null && col.gameObject.tag == "Enemy"){
			Zombie zombie = col.gameObject.GetComponent<Zombie>();
			health -= zombie.getHit();
			if(health <= 0){
				Destroy(this.gameObject);
			}
		}
	}
	
	
}
