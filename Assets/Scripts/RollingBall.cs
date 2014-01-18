using UnityEngine;
using System.Collections;

public class RollingBall : MonoBehaviour {

	// Use this for initialization
	void Start () {

		transform.rigidbody.AddForce(Vector3.left * 750);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
