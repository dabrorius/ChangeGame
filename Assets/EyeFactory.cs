using UnityEngine;
using System.Collections;

public class EyeFactory : MonoBehaviour {

	public GameObject EyePrefab;
	public float CreationDelay;
	public float Radius;

	private float elapsedTime = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime;
		if( Input.GetKeyDown(KeyCode.C) || (elapsedTime >= CreationDelay) ) {
			Instantiate(EyePrefab, gameObject.transform.position, Quaternion.identity);
			gameObject.transform.position = new Vector2(Random.Range(-Radius, Radius), gameObject.transform.position.y);
			elapsedTime = 0;
		}
	}
}
