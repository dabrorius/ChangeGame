using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

	public float jumpPower;
	public Animator anim;
	public bool grounded = false;
	public Transform groundCheck;
	public float speed;
	public string axisName = "Horizontal";

	private string jumpButton = "Fire2";

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Walls"));

		anim.SetBool("InAir",! grounded);// ("Jump");

		if( Input.GetButtonDown(jumpButton) ) {
			rigidbody2D.velocity = new Vector2( rigidbody2D.velocity.x, jumpPower );
		} 


		if( ! grounded ) {
			rigidbody2D.velocity = new Vector2( Input.GetAxis(axisName) * speed, rigidbody2D.velocity.y );
		}

		if( rigidbody2D.velocity.x > 5) {
			this.transform.eulerAngles = new Vector3(0,0,-8);
		} else if( rigidbody2D.velocity.x < -5) {
			this.transform.eulerAngles = new Vector3(0,0,8);
		} else {
			this.transform.eulerAngles = new Vector3(0,0,0);
		}

		if( Input.GetAxis(axisName) < 0 ) {
			transform.localScale = new Vector2(-1,1);
		} 
		
		if( Input.GetAxis(axisName) > 0 ) {
			transform.localScale = new Vector2(1,1);
		}
	}
}
