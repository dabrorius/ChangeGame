using UnityEngine;
using System.Collections;

public class EndScreen : MonoBehaviour {

	public SpriteRenderer target;
	
	public float fadeInDelay = 5.0f;
	public float fadeInDuration = 3.0f;
	public float switchLevelDelay = 2.0f;
	
	private float elapsed = 0.0f;
	
	
	// Use this for initialization
	void Start () {
		target.material.color = new Color(target.material.color.r, target.material.color.g, target.material.color.b, 0);
	}
	
	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;

		if( elapsed > fadeInDelay)
		{
			float newAlpha = (elapsed - fadeInDelay) / fadeInDuration;
			if(newAlpha >= 1.0f){
				newAlpha = 1.0f;
				if( elapsed > (fadeInDelay + fadeInDuration + switchLevelDelay) ) 
				{
					Application.LoadLevel("MainMenu");
				}
			}
					
			target.material.color = new Color(target.material.color.r, target.material.color.g, target.material.color.b, newAlpha);
		}
	}
}
