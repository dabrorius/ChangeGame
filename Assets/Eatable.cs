﻿using UnityEngine;
using System.Collections;

public class Eatable : MonoBehaviour {

	public ParticleSystem Blood;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col) {
		Debug.Log("Collision enter");
		if (col.gameObject.tag == "Player" ) {
			Instantiate(Blood, gameObject.transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}


}
