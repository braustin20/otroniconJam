using UnityEngine;
using System.Collections;


public class tileFallingBehavior : MonoBehaviour {

	public float waitTime = 0.30f;
	private bool isRigid = false;
	private Vector3 explosion;
		// Use this for initialization
	void Start () {
		explosion = new Vector3(Random.Range (-25.0f,25.0f), 0 , Random.Range (-25.0f, 25.0f));
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
			gameObject.rigidbody.AddTorque(explosion);
			isRigid = true;
		}
	}


}
