using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GameObject.Find ("OVRCameraController").GetComponent<OVRCameraController>().CameraRootPosition.x = PlayerPrefs.GetFloat("PlayerX");
		//GameObject.Find ("OVRCameraController").GetComponent<OVRCameraController>().CameraRootPosition.y = PlayerPrefs.GetFloat("PlayerY") + 500.0f;
		//GameObject.Find ("OVRCameraController").GetComponent<OVRCameraController>().CameraRootPosition.z = PlayerPrefs.GetFloat ("PlayerZ");
		GameObject.FindWithTag ("Player").transform.position = new Vector3(PlayerPrefs.GetFloat ("PlayerX"), PlayerPrefs.GetFloat ("PlayerY") + 5.0f, PlayerPrefs.GetFloat ("PlayerZ"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
