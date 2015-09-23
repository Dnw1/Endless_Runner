using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	//controls players speed
	public float moveSpeed;
	//increases player's speed * speedmultiplier
	public float speedMultiplier;

	//controls milestone at which speed will increase
	public float speedIncreaseMilestone;
	private float speedMilestoneCount;

	//controls player jump
	public float jumpForce;
	public float jumpTime;
	private float jumpTimeCounter;

	//gets rigidbody2d so it can be placed on player
	private Rigidbody2D myRigidbody;

	//checks if player is on the ground
	public bool grounded;
	public LayerMask whatIsGround;
	public Transform groundCheck;
	public float groundCheckRadius;
	
	void Start () 
	{
		myRigidbody = GetComponent<Rigidbody2D> ();

		jumpTimeCounter = jumpTime;
		speedMilestoneCount = speedIncreaseMilestone;
	}
	void Update ()
	{
		//grounded = Physics2D.IsTouchingLayers (myCollider, whatIsGround);

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

		if (transform.position.x > speedMilestoneCount) 
		{
			speedMilestoneCount += speedIncreaseMilestone;

			speedIncreaseMilestone = speedIncreaseMilestone * speedMultiplier;
			moveSpeed = moveSpeed * speedMultiplier;
		}

		myRigidbody.velocity = new Vector2 (moveSpeed, myRigidbody.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) 
		{
			if(grounded)
			{
				myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
			}
		}

		if (Input.GetKey (KeyCode.Space) || Input.GetMouseButton (0)) 
		{
			if(jumpTimeCounter > 0)
			{
				myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
				jumpTimeCounter -= Time.deltaTime;
			}
		}

		if (Input.GetKeyUp (KeyCode.Space) || Input.GetMouseButtonUp (0)) 
		{
			jumpTimeCounter = 0;
		}
		if(grounded)
		{
			jumpTimeCounter = jumpTime;
		}
	}
}