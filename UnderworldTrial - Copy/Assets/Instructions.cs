using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {
		GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Welcome to the Underworld. Collect the 18 blood-red Soul Lights to pass through the Black Door. Use arrow keys to move.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
