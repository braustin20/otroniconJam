using UnityEngine;
using System.Collections;

public class Level9 : MonoBehaviour {

	public GameObject first;
	bool hasFired;

	void Start() {
		hasFired = false;
	}

	void OnTriggerEnter(Collider other) {
		if (!hasFired)
			first.SendMessage("Go", this.transform.position, SendMessageOptions.DontRequireReceiver);
	}

	public void Reset() {
		hasFired = false;
	}
}
