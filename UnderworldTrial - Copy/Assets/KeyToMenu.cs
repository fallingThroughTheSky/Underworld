using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeyToMenu : MonoBehaviour {

	void OnGUI(){
		if (Event.current.Equals (Event.KeyboardEvent ("m"))) {
			//Application.LoadLevel (0);
			SceneManager.LoadScene (0);
			
		}
	}






	//private bool noMenu = false;
	//void Update()
	//{
		//if (noMenu == false && Input.GetKeyDown (KeyCode.M))
			//Debug.Log ("M key was pressed.");
		//{
			//SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
			//noMenu = true;
		//}
	 // if (Input.GetKeyDown(KeyCode.M) && noMenu == true) 
		//{
			//noMenu = false;
		//}
//	}








	//private bool noMenu = false;
	
	// Update is called once per frame
	//void Update () {

		






			//if (noMenu ==false && Input.GetKeyDown (KeyCode.M))
		//	Debug.Log("M key was pressed.");
		
	//}
}
