using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_object : MonoBehaviour {
    public GameObject platform;
    // Use this for initialization
    float offsetX = 8;
    float offsetY = 0;
	float fTime = 1f;
    public float Offtime = 1f;
	void Start () { 
    }
	
	// Update is called once per frame
	void Update () {
        if (fTime < Time.realtimeSinceStartup)
        {
            float offsetY = Random.Range(-5f,2f);
            Instantiate(platform, new Vector3(offsetX, offsetY, -5), Quaternion.identity);
			fTime = Time.realtimeSinceStartup + Offtime+ Random.Range(0f, 2f);
        }
        else {}
    }
}
