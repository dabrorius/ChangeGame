using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float jumpPower;
	public Animator anim;
	public bool grounded = false;
	public Transform groundCheck;
	public float evolutionSickness = 0.0f;

	private string jumpButton = "Fire2";

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		Debug.Log("Started jump script");
	}
	
	// Update is called once per frame
	void Update () {
		bool oldGrounded = grounded;
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Walls"));

		if(evolutionSickness > 0) {
			evolutionSickness -= Time.deltaTime;
			return;
		}
	
		if( Input.GetButtonDown(jumpButton) && grounded ) {
			anim.SetTrigger("Jump");
			rigidbody2D.velocity = new Vector2( rigidbody2D.velocity.x, jumpPower );
			//rigidbody2D.AddForce(transform.up * jumpPower);
		} else {
			anim.ResetTrigger("Jump");
		}

		if( grounded && !oldGrounded ) {
			anim.SetTrigger("Land");
		}
		if (grounded && oldGrounded) {
			anim.ResetTrigger("Land");
		}
	}
}
