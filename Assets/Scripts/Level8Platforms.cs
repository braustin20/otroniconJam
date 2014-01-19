using UnityEngine;
using System.Collections;

public class Level8Platforms : MonoBehaviour {

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

	public void Create() {

		StartCoroutine("Spawn");
	}

	IEnumerator Spawn() {
		transform.localScale = Vector3.one / 10;

		while (transform.localScale.x < 1) {
			transform.localScale += Vector3.one * Time.deltaTime;
			yield return 0;
		}

	}
}
