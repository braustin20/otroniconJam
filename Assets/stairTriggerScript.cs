using UnityEngine;
using System.Collections;

public class stairTriggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

		if(other.tag == "Player" && gameObject.name == "stairTrigger"){
			GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().moved = 0.0f;
			GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().activated = 0;
		}
		if(other.tag == "Player" && gameObject.name == "stairTriggerOff"){
			GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().moved = 0.0f;
			GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().activated = 1;

		}

	}
}
