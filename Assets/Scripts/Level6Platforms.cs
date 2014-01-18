using UnityEngine;
using System.Collections;

public class Level6Platforms : MonoBehaviour {

	GameObject GameManager;

	// Use this for initialization
	void Start () {

		GameManager = GameObject.FindGameObjectWithTag("GameController");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		GameManager.SendMessage("PlatformTrigger", this.transform.position, SendMessageOptions.DontRequireReceiver);
	}

	public void Fall() {
		this.gameObject.AddComponent<Rigidbody>();
		this.rigidbody.useGravity = true;
	}
}
