using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Animator anim;
	public float speed;
	public string axisName = "Horizontal";
	public float evolutionSickness = 0.0f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(evolutionSickness > 0) {
			evolutionSickness -= Time.deltaTime;
			return;
		}

		//rigidbody2D.AddForce( Input.GetAxis(axisName) * Vector2.right * speed);
		rigidbody2D.velocity = new Vector2( Input.GetAxis(axisName) * speed, rigidbody2D.velocity.y );
		anim.SetFloat("Speed",  Mathf.Abs(Input.GetAxis(axisName)) ); 

		if( Input.GetAxis(axisName) < 0 ) { transform.localScale = new Vector2(-1,1); } 
		if( Input.GetAxis(axisName) > 0 ) { transform.localScale = new Vector2(1,1); }
	}
}
