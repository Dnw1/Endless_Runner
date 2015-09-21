using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{	
	public float Speed = 5f;
	public float MaxJumpTime = 2f;
	public float JumpForce;
	private float move = 5f;
	private float JumpTime = 4f;
	private bool CanJump;
	
	
	void Start () {
		JumpTime  = MaxJumpTime;
	}
	
	
	void Update ()
	{
		if (!CanJump)
			JumpTime  -= Time.deltaTime;
		if (JumpTime <= 0)
		{
			CanJump = true;
			JumpTime  = MaxJumpTime;
		}
	}
	
	void FixedUpdate () {
		move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * Speed, GetComponent<Rigidbody2D>().velocity.y);
		if (Input.GetKey (KeyCode.W)  && CanJump)
		{
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (GetComponent<Rigidbody2D>().velocity.x,JumpForce));
			CanJump = false;
			JumpTime  = MaxJumpTime;
		}
	}
}






	/*
	public float maxSpeed = 10f;
	bool facingRight = true;

	private ParallaxController _parallaxController;
	
	void Awake()
	{
		_parallaxController = GetComponent<ParallaxController> ();
	}
	void Start(){

	}
	void FixedUpdate ()
	{
		float move = Input.GetAxis ("Horizontal");

		Rigidbody2D.velocity = new Vector2 (move * maxSpeed, Rigidbody2D.velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
			Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, jumpHeight);
		else if(Input.GetKey(KeyCode.D))
		   Rigidbody2D.velocity = new Vector2(movementSpeed, Rigidbody2D.velocity.y);
		else if(Input.GetKey (KeyCode.A))
			Rigidbody2D.velocity = new Vector2(-movementSpeed, Rigidbody2D.velocity.y);
	}*/