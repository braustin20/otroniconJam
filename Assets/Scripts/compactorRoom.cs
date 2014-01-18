using UnityEngine;
using System.Collections;

public class compactorRoom : MonoBehaviour {
	public bool activated;
	public GameObject leftWall;
	public GameObject rightWall;
	public float moveDistance = 13.0f;
	private float moved = 0.0f;
	public float moveSpeed = 0.2f;
	public int wallsTouching;

	// Use this for initialization
	void Start () {
		activated = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(activated && moved < moveDistance){
			leftWall.transform.position += new Vector3(moveSpeed, 0.0f, 0.0f);
			rightWall.transform.position += new Vector3(-moveSpeed, 0.0f, 0.0f);
			moved += moveSpeed;
			Debug.Log(moved);
		}
		if(wallsTouching > 0){
			Debug.Log("Player is dead");
		}
	}

}
