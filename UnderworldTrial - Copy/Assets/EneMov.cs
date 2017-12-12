using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneMov : MonoBehaviour {

	Transform player;

	UnityEngine.AI.NavMeshAgent nav;
	// Use this for initialization
	void Awake () {

		player = GameObject.FindGameObjectWithTag ("EthanBody").transform;
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination (player.position);
	}
}
