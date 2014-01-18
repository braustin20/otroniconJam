using UnityEngine;
using System.Collections;

public class stepsMovement : MonoBehaviour {
	public int activated = -1;
	public float moveDistance = 1.0f;
	public float moved = 0.0f;
	public float moveSpeed = 0.05f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(activated == 0 && moved < moveDistance){
			gameObject.transform.Translate (new Vector3(0.0f, 0.0f, -moveSpeed));
			//rightWall.transform.position += new Vector3(-moveSpeed, 0.0f, 0.0f);
			moved += moveSpeed;
			Debug.Log(moved);
		}
		if(activated == 1  && moved < moveDistance){
			gameObject.transform.Translate (new Vector3(0.0f, 0.0f, moveSpeed));
			moved += moveSpeed;
		}

	}

}
