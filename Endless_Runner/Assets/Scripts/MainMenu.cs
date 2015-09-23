using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
		
	public GUISkin guiskin;
	
	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.32f, Screen.height * 0.22f, 400, 400), "Main Menu: AntRush");
		
		if(GUI.Button(new Rect(Screen.width * 0.42f,Screen.height * 0.35f,Screen.width * 0.2f,Screen.height * 0.1f), "Play")){
			Application.LoadLevel("Scene");
		}   //Scene is de scene van de game.
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.5f, Screen.width * 0.2f, Screen.height * 0.1f), "Credits")) {
			Application.LoadLevel("Credits");
		}
		
	}
}