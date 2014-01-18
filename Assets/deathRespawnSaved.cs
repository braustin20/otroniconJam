using UnityEngine;
using System.Collections;

public class deathRespawnSaved : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
		Debug.Log (GameObject.FindWithTag("Player").transform.position.x);

		Application.LoadLevel("TestScene2");
		Debug.Log (GameObject.FindWithTag("Player").transform.position.x);

		Debug.Log ("X: " + PlayerPrefs.GetFloat("PlayerX"));
		
		Debug.Log (GameObject.FindWithTag("Player").transform.position.x);
		}
	}
}
