using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	// Use this for initialization
	void Start () {

		StartCoroutine("LifeCycle");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator LifeCycle() {
		yield return new WaitForSeconds(30 - transform.position.y + 25);
		Destroy (this.gameObject);
	}
}
