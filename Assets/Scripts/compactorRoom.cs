using UnityEngine;
using System.Collections;

public class compactorRoom : MonoBehaviour {
	public bool activated;
	public GameObject leftWall;
	public GameObject rightWall;

	// Use this for initialization
	void Start () {
		activated = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(activated){
			leftWall.rigidbody.AddForce(10000,0,0);
			activated = false;
		}
	}
}
