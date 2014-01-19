using UnityEngine;
using System.Collections;

public class torchScript : MonoBehaviour {
	public float randomStartingTime;

	// Use this for initialization
	void Start () {
		randomStartingTime = Random.Range(0.4f, 18.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
