using UnityEngine;
using System.Collections;

public class Level7Platforms : MonoBehaviour {

	GameObject GameManager;

	// Use this for initialization
	void Start () {

		GameManager = GameObject.FindGameObjectWithTag("GameController");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		GameManager.GetComponent<Level7>().PlatformTrigger(this.transform.position);
	}

	public void Rise(float amount) {
		StartCoroutine("Float", amount);
	}

	IEnumerator Float(float amount) {
		float initPos = transform.position.y;

		while ( transform.position.y <= initPos + amount) {
			transform.position += Vector3.up * 5 * Time.deltaTime;
			yield return 0;
		}

	}
}
