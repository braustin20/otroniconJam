using UnityEngine;
using System.Collections;

public class Axe : MonoBehaviour {

	int vMod;
	public float theta;
	bool isRight;
	public float initialSpeed = 10;
	public float swingSpeed = 300;
	float sMod;
	// Use this for initialization
	void Start () {
		isRight = true;
		vMod = 1;
		sMod = 0;
	}
	
	// Update is called once per frame
	void Update () {

		sMod = 1 - Mathf.Abs(Mathf.Cos (transform.rotation.z));

		theta += ((initialSpeed + (sMod * swingSpeed)) * vMod * Time.deltaTime) % 360;

		if ((theta < 75 && !isRight) || (theta > 285 && isRight)){
			vMod *= -1;
			isRight = !isRight;
		}

		transform.rotation = Quaternion.Euler (0, 0, theta);
	}
}
