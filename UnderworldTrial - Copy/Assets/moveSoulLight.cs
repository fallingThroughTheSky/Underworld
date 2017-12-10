using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSoulLight : MonoBehaviour {
	

	public GameObject soulHolder;
	public GameObject player;
	public Transform startMarker;
	public Transform endMarker;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;


	void Start(){
		
		
		
	
		startTime = Time.time; 
		journeyLength = Vector3.Distance (startMarker.position, endMarker.position);
	}
	void Update(){
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		if (player.transform.parent == null) {
			transform.position = Vector3.Lerp (startMarker.position, endMarker.position, fracJourney);
		}
		//if(player.GetComponentInParent = null)
			//SetParent(GameObject soulHolder);
			//		if (player.transform.parent == null)
			//			player.transform.parent==ThirdPersonController.transform;
			//
			}
	



		
}
