using System.Collections;
using UnityEngine;

public class PlayerContral : MonoBehaviour {
	private float runspeed=50;
	private float jumphight=1000;
	private Rigidbody2D body;
	private Animator animator;

	private bool jumping = false;
	private bool isGround= false;
	private bool attack = false;
	void Awake()
	{
		body = GetComponent<Rigidbody2D>();	
		animator = GetComponent<Animator> ();
	}
	void FixedUpdate () {
		move();
		jump ();
	}
	void move()
	{
		float speed = Input.GetAxis ("Horizontal") * runspeed;
		Vector2 movement = new Vector2 (speed,0);
		body.AddForce(movement);
//		if (speed != 0) 
//		{
//			if(Mathf.Sign (body.velocity.x) == 1)
//			{
//				transform.localScale = new Vector2(1, 0);
//			}
//			else
//			{	
//				transform.localScale = new Vector2(-1, 0);
//			}
//		}
	}
	void jump()
	{
		if (body.velocity.y != 0)
			return;
		else
		{
			if (Input.GetButtonDown ("Jump")) 
			{
				Vector2 UP = new Vector2 (0, jumphight); 
				body.AddForce (UP);
			}
		}
	}
}
