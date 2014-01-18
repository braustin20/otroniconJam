using UnityEngine;
using System.Collections;

public class wallDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Player"){
			gameObject.transform.parent.gameObject.GetComponent<compactorRoom>().wallsTouching += 1;
		}
		if(other.gameObject.tag == "closingWall"){
			gameObject.transform.parent.gameObject.GetComponent<compactorRoom>().activated = false;
		}
	}

}
