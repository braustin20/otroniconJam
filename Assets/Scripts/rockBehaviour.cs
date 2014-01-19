using UnityEngine;
using System.Collections;

public class rockBehaviour : MonoBehaviour {

	private Vector3 explosion;

	// Use this for initialization
	void Start () {

	 explosion = new Vector3(Random.Range (-25.0f,25.0f), 0 , Random.Range (-25.0f, 25.0f));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		Debug.Log ("HIT");
		gameObject.rigidbody.AddForce(explosion);

		if(collision.gameObject.name == "JumpingOVR"){
			Debug.Log ("Player hit");
			//gameObject.SendMessage ("rocksHitMe");
			gameObject.GetComponent<thisscriptworks>().rocksHitMe();
		}
	}
}
