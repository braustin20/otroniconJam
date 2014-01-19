using UnityEngine;
using System.Collections;

public class playerInteract : MonoBehaviour {
	public GameObject grabbedRope;
	public GameObject closestRope;
	public string usingAxis;
	private bool isBobbing;
	private bool ropeRange;
	private bool holding;

	// Use this for initialization
	void Start () {
		isBobbing = true;
		ropeRange = false;
		holding = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(holding == true && usingAxis == "x"){
			this.transform.position = grabbedRope.transform.position + (grabbedRope.transform.forward + new Vector3(0.0f, -1.5f, 0.0f));
		}
		if(holding == true && usingAxis == "z"){
			this.transform.position = grabbedRope.transform.position + (grabbedRope.transform.forward + new Vector3(0.0f, -1.5f, 0.0f));
		}

		if(Input.GetKey(KeyCode.W) && holding == true && grabbedRope.rigidbody.velocity.magnitude < 12.0f){
			grabbedRope.rigidbody.AddForce(transform.forward * 15);
			Debug.Log(grabbedRope.rigidbody.velocity.magnitude);
		}
		if(Input.GetKey(KeyCode.S) && holding == true && grabbedRope.rigidbody.velocity.magnitude < 12.0f){
			grabbedRope.rigidbody.AddForce(-transform.forward * 15);
		}
		if(Input.GetKeyDown(KeyCode.E)){
			if(ropeRange == true && holding == false){
				grabbedRope = closestRope;
				holding = true;
				isBobbing = false;
				this.gameObject.GetComponentInChildren<HeadBobber>().enabled = false;
			}
			else if(holding == true){
				grabbedRope = null;
				holding = false;
				isBobbing = true;
				this.gameObject.GetComponentInChildren<HeadBobber>().enabled = true;
				SendMessage("SetVelocity", transform.forward * 20.0f);
			}
		}
	}
	public void inRange(GameObject rope){
		this.gameObject.GetComponentInChildren<HeadBobber>().enabled = false;
		closestRope = rope;
		ropeRange = true;
	}
	public void outRange(GameObject rope){
		if (rope == closestRope){
			closestRope = null;
			ropeRange = false;
		}
	}
}
