using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject zombiePrefab;
	
	[Range(0.9f, 1.0f)]public float threshold = 0.9f;
	// Use this for initialization
	void Start () {
		foreach(Transform child in transform){
			float random = Random.Range(0f,1f);
			if(random > threshold){
				GameObject zombie = (GameObject) Instantiate(zombiePrefab, child.transform.position ,Quaternion.identity);
				zombie.transform.parent = child;
				zombie.tag = "Enemy";
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		Start();
	}
}
