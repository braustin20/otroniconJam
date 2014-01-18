using UnityEngine;
using System.Collections;

public class checkPointBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other){
		//Saves player location for future spawn after unfortunate and untimely death.
		PlayerPrefs.SetFloat ("PlayerX", transform.position.x);
		PlayerPrefs.SetFloat ("PlayerY", transform.position.y);
		PlayerPrefs.SetFloat ("PlayerZ", transform.position.z);
		Debug.Log ("SAVED LOCATIONS. X: " + transform.position.x);
		Debug.Log ("X: " + PlayerPrefs.GetFloat ("PlayerX"));
	}


}
