using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	public GUIStyle mystyle;
	// Use this for initialization
	void Start () {
		
	}
	void OnGui(){
		if (GUI.Button (new Rect (Screen.width * 0.28f, Screen.height * 0.25f, Screen.width * 0.5f, Screen.height * 0.1f), "Старт", mystyle)) 
		{
			Application.LoadLevel ("Dark world");
		}
		if (GUI.Button (new Rect (Screen.width * 0.28f, Screen.height * 0.5f, Screen.width * 0.5f, Screen.height * 0.1f), "Виход", mystyle))
		{
			Application.Quit();
		}
	}
	// Update is called once per frame
	void Update () {
	}
}
