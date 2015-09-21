using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {
	
	public GUISkin crskin;
	
	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.32f, Screen.height * 0.13f, 400, 200), "Credits");
		GUI.Label (new Rect (Screen.width * 0.50f, Screen.height * 0.21f, Screen.width * 0.2f, Screen.height * 0.1f), "Dylan Waij");
		GUI.Label (new Rect (Screen.width * 0.50f, Screen.height * 0.28f, Screen.width * 0.2f, Screen.height * 0.1f), "Kick Hulst");
		if (GUI.Button (new Rect (Screen.width * 0.44f, Screen.height * 0.326f, Screen.width * 0.2f, Screen.height * 0.1f), "Main Menu")) {
			Application.LoadLevel ("MainMenu");
		}
	}
}