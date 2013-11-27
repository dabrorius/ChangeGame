using UnityEngine;
using System.Collections;

public class CreateEndScreen : MonoBehaviour {

	public EndScreen endScreenRef;
	// Use this for initialization
	void Start () {
		Instantiate(endScreenRef);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
