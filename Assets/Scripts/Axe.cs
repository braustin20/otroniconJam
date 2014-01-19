using UnityEngine;
using System.Collections;

public class Axe : MonoBehaviour {

	JointMotor motor;
	float timer;
	int velocityMod;

	// Use this for initialization
	void Start () {
		motor = this.hingeJoint.motor;
		timer = 2f;
		velocityMod = 1;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0) {
			velocityMod *= -1;
			timer = 2f;
		}

		motor.targetVelocity = 500 * velocityMod * Mathf.Cos ((timer / 2));

		this.hingeJoint.motor = motor;

	}
}
