 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEHAVIOR : MonoBehaviour
{
	Animator anima;
    public Transform GroundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    public Transform person;

	public LayerMask Enemy;
	public float enemyRadius;
	private bool bTouchEnemy;

	public GameObject Fire;
	public GameObject GameOver;
	public Vector3 offset = new Vector3 (1, 1, -5);

    Vector2 jump = new Vector2(0, 150);
    Vector2 Up = new Vector2(0, 15);
    Vector2 left = new Vector2(-15, 0);
    Vector2 right = new Vector2(15, 0);
    Vector2 down= new Vector2(0, -15);

    private Rigidbody2D RB2D;
    // Use this for initialization
    void Start()
    {
		anima = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
	{
		
      
		RB2D = GetComponent<Rigidbody2D> ();
		isTouchingGround = Physics2D.OverlapCircle (GroundCheckPoint.position, groundCheckRadius, groundLayer);
		bTouchEnemy = Physics2D.OverlapCircle (transform.position, enemyRadius, Enemy);
		if (Input.GetKeyDown (KeyCode.Space) && isTouchingGround)
			RB2D.AddForce (jump);
		if (Input.GetKeyDown (KeyCode.W) && isTouchingGround)
			RB2D.AddForce (Up);
		if (Input.GetKey (KeyCode.S) && isTouchingGround) {
			RB2D.AddForce (down);
			anima.SetInteger ("state", 0);
		}
		if (Input.GetKey (KeyCode.D) && isTouchingGround) {
			RB2D.AddForce (right);
			anima.SetInteger ("state", 2);
		}
		if (Input.GetKey (KeyCode.A) && isTouchingGround) {
			RB2D.AddForce (left);
			anima.SetInteger ("state", 1);
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			Instantiate (Fire, (person.position + offset), Quaternion.identity);
			anima.SetInteger ("state", 3);
		}
		if (transform.position.y < -5f) {
			Instantiate (GameOver, new Vector2 (0, 0), Quaternion.identity);
			GameObject.Destroy (this.gameObject);
		}
		if (bTouchEnemy) {	
			Instantiate (GameOver, new Vector2 (0, 0), Quaternion.identity);
			GameObject.Destroy (this.gameObject);
		}
	}    
}
