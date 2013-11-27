using UnityEngine;
using System.Collections;

public class LevelFader : MonoBehaviour {

	public SpriteRenderer target;
	
	public float fadeInDuration = 1.0f;
	private float elapsed = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;
		float newAlpha = 1 - elapsed / fadeInDuration;
		if(newAlpha < 0.0f) newAlpha = 0.0f;
		target.material.color = new Color(target.material.color.r, target.material.color.g, target.material.color.b, newAlpha);
	}
}
