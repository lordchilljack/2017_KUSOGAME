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
	void Awake()//初始
	{
		body = GetComponent<Rigidbody2D>();	//函式庫縮寫
		animator = GetComponent<Animator> (); //函式庫縮寫
	}
	void FixedUpdate () {
		move();
		jump ();
	}
	void move()
	{
		float speed = Input.GetAxis ("Horizontal") * runspeed;//當按水平左右鍵的時候
		Vector2 movement = new Vector2 (speed,0);
		body.AddForce(movement);//給予gameObj 水平力
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
		if (body.velocity.y != 0)//若還沒洛帝或是上升中禁用跳躍
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
