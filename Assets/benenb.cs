using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class benenb : MonoBehaviour {
	float fTime = 0f;
	Vector2 migratio = new Vector2 (-1.2f, 0);
	// Use this for initialization
	void Start () {
		fTime = Time.realtimeSinceStartup + 25;	
	}
	
	// Update is called once per frame
	void Update () {
		if (fTime > Time.realtimeSinceStartup)
			transform.Translate (migratio * Time.deltaTime);
		else {

			Object.Destroy (this.gameObject);

		}
	}
}
