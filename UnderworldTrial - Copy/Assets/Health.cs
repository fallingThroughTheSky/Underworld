using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public int starthealth = 20;
	public int curhealth;
	public UnityEngine.UI.Slider healSlider;
	public float flashSpeed = 5f;
	public Color flashColour = new Color (2f, 0f, 0f, 0.1f);

	// Use this for initialization
	void Awake () {
		curhealth = starthealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TakeDamage (int amount) {
		curhealth -= amount;
		healSlider.value = curhealth;
	}
}
