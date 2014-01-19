using UnityEngine;
using System.Collections;

public class Level9 : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject[] objects = GameObject.FindGameObjectsWithTag("Path1");
		foreach (GameObject p in objects)
			p.renderer.material.color = new Color(255, 0, 0, 155);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
