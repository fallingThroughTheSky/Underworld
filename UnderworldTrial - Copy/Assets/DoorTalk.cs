using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorTalk : MonoBehaviour {
	public GameObject globalScript; 

	// Use this for initialization
	void OnGUI () {
		GUI.Label(new Rect(0, 0, 80, 20), "Collected: "+globalScript.GetComponent<killCount>().killCountNumber);
	}

	
	// Update is called once per frame
	void Update () {
		 
	}
}
