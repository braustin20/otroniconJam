using UnityEngine;
using System.Collections;

public class SetPiece : MonoBehaviour {

	bool waitForPlayer;
	bool hasWaited;

	// Use this for initialization
	void Start () {

		hasWaited = false;
		waitForPlayer = true;
		Debug.Log (waitForPlayer);
		//rigidbody.AddForce(Vector3.up * 100);

	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >= 59.5 && !hasWaited) {
			waitForPlayer = true;
			hasWaited = true;
			rigidbody.velocity = Vector3.zero;
		}
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log (waitForPlayer);
		if (waitForPlayer) {
			Debug.Log ("L");
			waitForPlayer = false;
			rigidbody.AddForce(Vector3.up * 100);
		}
	}
}
