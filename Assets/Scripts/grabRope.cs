using UnityEngine;
using System.Collections;

public class grabRope : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			other.gameObject.GetComponent<playerInteract>().grabbedRope = this.gameObject;
			this.gameObject.rigidbody.AddForce(other.gameObject.transform.forward * 500);
			other.gameObject.GetComponent<FPSInputController>().enabled = false;
		}
	}
}
