using UnityEngine;
using System.Collections;


public class tileFallingBehavior : MonoBehaviour {

	public float waitTime = 0.30f;
	private bool isRigid = false;
		// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		//gameObject.AddComponent("Rigidbody");

		if(other.tag != "fallingPlatform"){
		StartCoroutine(Fall());
		}
	}


	IEnumerator Fall() {

			//Debug.Log ("ENTERED");
			yield return new WaitForSeconds(waitTime);
		if(isRigid == false){
			gameObject.AddComponent("Rigidbody");
			isRigid = true;
		}
	}


}
