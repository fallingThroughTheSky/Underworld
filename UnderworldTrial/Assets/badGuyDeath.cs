using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class badGuyDeath : MonoBehaviour {
	public float Health =5;
	GameObject badGuy;
	GameObject EthanBody;

	void Update (){
		if (Health <= 0)
			DetachFromParent ();

		//Destroy(self), but when get character change this so that character falls to ground, have door script make trigger have baddies get up and start walking again so if look back from top of ridge can see them moving
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "EthanBody")
			Health= Health - 1;

	}

	public void DetachFromParent()
	{
		transform.parent = null;
	}




			}

	 





