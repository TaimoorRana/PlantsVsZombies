using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlantSpawner : MonoBehaviour {
	public Plant plantPrefab;
	private static float timeDelay;
	private static bool spawnAllowed;
	public Slider timeSlider;
	public AudioClip audio1;
	// Use this for initialization
	void Start () {
		timeDelay = 0f;
		spawnAllowed = false;
		timeSlider.minValue = 0f;
		timeSlider.maxValue = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		timeDelay += Time.deltaTime;
		
		if(timeDelay > 3f){
			spawnAllowed = true;
			print (timeDelay);
		}	
		timeSlider.value = timeDelay;
	}
	
	public bool SpawnHere(Vector3 position){
		if(spawnAllowed == true){
			spawnAllowed = false;
			Instantiate(plantPrefab,position,Quaternion.identity);
			timeDelay = 0f;
			AudioSource.PlayClipAtPoint(audio1,transform.position);
			return true;
		}
		return false;
	}
	
	public static float getTimeDelay(){
		return timeDelay;
	}
}
