using UnityEngine;
using System.Collections;


public class tileFallingBehavior : MonoBehaviour {

	public float waitTime = 0.23f;
		// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		//gameObject.AddComponent("Rigidbody");

		StartCoroutine(Fall());
	}


	IEnumerator Fall() {

			Debug.Log ("ENTERED");


			yield return new WaitForSeconds(waitTime);
		gameObject.AddComponent("Rigidbody");

	}


}
