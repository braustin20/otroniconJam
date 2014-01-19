using UnityEngine;
using System.Collections;

public class playerInteract : MonoBehaviour {
	public GameObject grabbedRope;
	public GameObject closestRope;
	public string usingAxis;
	private bool isBobbing;
	private bool ropeRange;
	private bool holding;
	private bool isGrounded = true;
	private float timez;
	private float deadTime;
	public bool isdead;

	// Use this for initialization
	void Start () {
		isBobbing = true;
		ropeRange = false;
		holding = false;
		isdead = false;
		timez = 0;
	}

	 public bool deadReturn(){

		return isdead;
	}

	void setGrounding(bool ground){

		isGrounded = ground;
	}

	// Update is called once per frame
	void Update () {

		SendMessage("somethingElse");

		//The following lines of code kill the player if he is in the air too long
		//********************

		if(!isGrounded && !holding){
			timez += Time.deltaTime;
		}
		if(isGrounded || holding){
			if(timez > 2.0f){
				isdead = true;
			}else{
				timez = 0;
			}
		}
		if(isdead){
			deadTime += Time.deltaTime;
			if(deadTime > 2.0f){
				Application.LoadLevel(Application.loadedLevel);
			}
		}

		//******************************


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

		}
		if(Input.GetKeyUp(KeyCode.E) || Input.GetButton("Fire1")){
			if(holding == true){
				grabbedRope = null;
				holding = false;
				isBobbing = true;
				this.gameObject.GetComponentInChildren<HeadBobber>().enabled = true;
				SendMessage("SetVelocity", transform.forward * 10.0f);
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
