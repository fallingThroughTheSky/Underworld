using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripte : MonoBehaviour {
	Animator anim1;
	// Use this for initialization
	void Start () {
		anim1 = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		bool hit = Input.GetMouseButtonDown (0);
		anim1.SetBool ("hit", hit);
	}
}
