using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {

	public GUIText target;

	public float fadeInDelay = 0.0f;
	public float fadeInDuration = 1.0f;
	public float blinkShow = 1.0f;
	public float blinkHide = 0.5f;

	private float elapsed = 0.0f;
	private float blinkCounter = 0.0f;
	private bool blinking = false;


	// Use this for initialization
	void Start () {
		target.material.color = new Color(target.material.color.r, target.material.color.g, target.material.color.b, 0);
	}

	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime;
		blinkCounter += Time.deltaTime;

		if( elapsed > fadeInDelay)
		{
			float newAlpha = (elapsed - fadeInDelay) / fadeInDuration;
			if(newAlpha >= 1.0f) newAlpha = 1.0f;

			if ( blinkHide > 0)
			{
				if( (blinkCounter > blinkShow ) && ! blinking)
				{
					blinking = true;
					blinkCounter = 0;
				}

				if( (blinkCounter > blinkHide) && blinking)
				{
					blinking = false;
					blinkCounter = 0;
				}

				if(blinking) {
					newAlpha = 0;
				}
			}


			target.material.color = new Color(target.material.color.r, target.material.color.g, target.material.color.b, newAlpha);
		}
	}
}
