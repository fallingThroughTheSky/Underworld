using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("badGuySoul"))
			other = GetComponent<Collider> ();
			other.isTrigger = true;

	}

		
}
