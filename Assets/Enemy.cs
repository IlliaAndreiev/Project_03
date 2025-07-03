using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private GameObject player;
	Vector3 Direction;

	public float checkRadius;
	public LayerMask bulletLayer;
	private bool isTouchBullet;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Guy");
	}
	
	// Update is called once per frame
	void Update () {
		isTouchBullet = Physics2D.OverlapCircle (transform.position, checkRadius, bulletLayer);
		Direction = player.transform.position - transform.position;
		GetComponent<Rigidbody2D> ().AddForce (20 * Time.deltaTime * Direction);
		if (isTouchBullet) {
			GameObject.Destroy (this.gameObject);
		}
		
	}
}
