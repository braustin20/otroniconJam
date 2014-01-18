using UnityEngine;
using System.Collections;

public class Level6Platforms : MonoBehaviour {

	GameObject GameManager;
	private Vector3 explosion;
	private bool isRigid = false;

	// Use this for initialization
	void Start () {

		this.explosion = new Vector3(Random.Range (-25.0f,25.0f), 0 , Random.Range (-25.0f, 25.0f));
		GameManager = GameObject.FindGameObjectWithTag("GameController");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		//Allows only the player to collide with cubes. Adjust if you want other collisions.
		if(other.tag == "Player"){
		GameManager.SendMessage("PlatformTrigger", this.transform.position, SendMessageOptions.DontRequireReceiver);
		}
	}

	public void Fall() {
		if(isRigid == false){
		this.gameObject.AddComponent<Rigidbody>();
		this.rigidbody.useGravity = true;
		this.gameObject.rigidbody.AddTorque(explosion);
		this.isRigid = true;
		}
	}
}
