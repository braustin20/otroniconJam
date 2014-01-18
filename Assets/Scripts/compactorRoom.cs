using UnityEngine;
using System.Collections;

public class compactorRoom : MonoBehaviour {
	public bool activated;
	public GameObject leftWall;
	public GameObject rightWall;
	public int wallsTouching;

	// Use this for initialization
	void Start () {
		activated = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(activated){
			leftWall.transform.position += new Vector3(0.2f, 0.0f, 0.0f);
			rightWall.transform.position += new Vector3(-0.2f, 0.0f, 0.0f);
		}
		if(wallsTouching == 2){
			Debug.Log("Player is dead");
		}
	}

}
