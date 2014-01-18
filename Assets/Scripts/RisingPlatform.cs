using UnityEngine;
using System.Collections;

public class RisingPlatform : MonoBehaviour {

	public float riseAmount;
	float initialHeight;
	// Use this for initialization
	void Start () {
		initialHeight = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		Debug.Log ("Collided");

		StartCoroutine("Rise");

	}

	IEnumerator Rise() {

		Debug.Log ("Rising");

		transform.rigidbody.velocity = Vector3.up * 5;

		while (true) {
			if (initialHeight + riseAmount <= transform.position.y) {
				transform.rigidbody.velocity = Vector3.zero;
				break;
			}
				yield return 0;
		}
	}
}
