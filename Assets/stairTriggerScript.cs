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
			if(GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().activated != 0){
			   GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().moved = 0.0f;
			   GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().activated = 0;
			}
		}
		if(other.tag == "Player" && gameObject.name == "stairTriggerOff"){
			if(GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().activated != 1){
			GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().moved = 0.0f;
			GameObject.FindGameObjectWithTag("stairObject").GetComponent<stepsMovement>().activated = 1;
			}
		}

	}
}
