using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {

	public float DestroyAfter = 1.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(DestroyAfter > 0) {
			DestroyAfter -= Time.deltaTime;
		}
		else {
			Destroy(gameObject);
		}
	}
}
