using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doorOpen : MonoBehaviour {
	
	private bool allDead = false;
	public GameObject doorCollider;
	public GameObject globalScript;
	public int killstoopendoor;
	public GameObject liveSoul;
	//public GameObject livingSoul;

	//public int openNumber;
	//public GameObject otherglobalScript;


	void Update (){
		if (allDead == false && globalScript.GetComponent<killCount>().killCountNumber >= killstoopendoor  ) {
			// door open

				allDead = true;
				Destroy(doorCollider);
			//&& otherglobalScript.GetComponent<returnNumber>().homeNumber >= openNumber
			//Destroy (livingSoul);
			}
		}

	}


		
