using UnityEngine;
using System.Collections;

public class compactorRoom : MonoBehaviour {
	public bool activated;
	public GameObject leftWall;
	public GameObject rightWall;
	public float pushForce = 100000f;
	public GameObject player;

	// Use this for initialization
	void Start () {
		activated = true;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(leftWall.rigidbody.velocity.x);
		if(activated && leftWall.rigidbody.velocity.x < 4){
			leftWall.rigidbody.AddForce(pushForce,0,0);
		}
	}
}
