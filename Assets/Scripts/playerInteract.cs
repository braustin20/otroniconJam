using UnityEngine;
using System.Collections;

public class playerInteract : MonoBehaviour {
	public GameObject grabbedRope;
	public string usingAxis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(grabbedRope != null && usingAxis == "x"){
			this.transform.position = grabbedRope.transform.position + new Vector3(1.0f, 1.0f, 0.0f);
		}
		if(grabbedRope != null && usingAxis == "z"){
			this.transform.position = grabbedRope.transform.position + new Vector3(0.0f, -.2f, 1.2f);
		}

		if(Input.GetKey(KeyCode.W) && grabbedRope != null){
			grabbedRope.rigidbody.AddForce(transform.forward * 15);
		}
		if(Input.GetKey(KeyCode.S) && grabbedRope != null){
			grabbedRope.rigidbody.AddForce(-transform.forward * 15);
		}
	}

}
