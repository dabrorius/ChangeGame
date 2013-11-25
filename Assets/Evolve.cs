using UnityEngine;
using System.Collections;

public class Evolve : MonoBehaviour {

	public GameObject Evolution;
	public float EvolutionDelay;

	private float elapsedTime = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime;
		if( Input.GetKeyDown(KeyCode.E) || (elapsedTime >= EvolutionDelay) ) {
			GameObject evolution = (GameObject) Instantiate(Evolution, gameObject.transform.position, Quaternion.identity);
			evolution.transform.localScale = transform.localScale;
			Destroy(gameObject);
		}
	}
}
