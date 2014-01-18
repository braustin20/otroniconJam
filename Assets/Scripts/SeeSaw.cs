using UnityEngine;
using System.Collections;

public class SeeSaw : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.name == "JumpingOVR")
			Debug.Log ("Hello");

	}
}
