using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {
	public static int nScore;
	Text textScore;

	// Use this for initialization
	void Start () {
		nScore = 0;
		textScore = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		textScore.text = "Score: " + nScore;
		nScore = (int)Time.timeSinceLevelLoad;
	}
}
