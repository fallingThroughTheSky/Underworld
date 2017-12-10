using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class badGuyDeath : MonoBehaviour {
	public float Health =5;
	GameObject badGuy;
	GameObject EthanBody;
	public GameObject bGSoulLight;
	public GameObject globalScript;
	public GameObject other;

	private bool dead = false;
	//public Transform endMarker;

	void Update (){
		if (Health <= 0) {
			DetachFromParent ();
			if (dead == false) {
				globalScript.GetComponent<killCount> ().killCountNumber++;
				dead = true;
			}
		}

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "EthanBody") {
			Health = Health - 1;
		}
	}

	public void DetachFromParent()
	{
		bGSoulLight.transform.parent = null;
	}




			}

	 





