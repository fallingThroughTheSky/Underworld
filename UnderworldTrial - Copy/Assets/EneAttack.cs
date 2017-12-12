using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneAttack : MonoBehaviour {

	public float timeBetween = 0.5f;
	public int attackDamage = 1;

	Animator anim2;
	GameObject player;
	Health playerHealth;
	bool playerInRange;
	float timer;

	// Use this for initialization
	void Awake () {

		player = GameObject.FindGameObjectWithTag ("EthanBody");
		playerHealth = player.GetComponent <Health>();
		anim2 = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {

		if (other.gameObject == player) {
			playerInRange = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject == player) {
			playerInRange = false;
		}
	}

	void Update() {
		timer += Time.deltaTime;

		if (timer >= timeBetween && playerInRange) {
			Attack ();
		}
	}

	void Attack() {
		timer = 0f;
		anim2.SetBool ("at", playerHealth.curhealth > 0);
	
		if (playerHealth.curhealth > 0) {
			playerHealth.TakeDamage (attackDamage);
		}
	}
}


