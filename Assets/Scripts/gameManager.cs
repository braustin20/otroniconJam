using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	bool toggleEsc;

	// Use this for initialization
	void Start () {
		//GameObject.Find ("OVRCameraController").GetComponent<OVRCameraController>().CameraRootPosition.x = PlayerPrefs.GetFloat("PlayerX");
		//GameObject.Find ("OVRCameraController").GetComponent<OVRCameraController>().CameraRootPosition.y = PlayerPrefs.GetFloat("PlayerY") + 500.0f;
		//GameObject.Find ("OVRCameraController").GetComponent<OVRCameraController>().CameraRootPosition.z = PlayerPrefs.GetFloat ("PlayerZ");
		GameObject.FindWithTag ("Player").transform.position = new Vector3(PlayerPrefs.GetFloat ("PlayerX"), PlayerPrefs.GetFloat ("PlayerY") + 5.0f, PlayerPrefs.GetFloat ("PlayerZ"));
		toggleEsc = false;

		if(Application.isPlaying){
			Screen.showCursor = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	if(Input.GetKeyDown (KeyCode.Escape) ){
			Application.Quit();

		}
	}
	void OnApplicationQuit(){
		Debug.Log("quitted");
		PlayerPrefs.SetFloat ("PlayerX", GameObject.Find("spawn").transform.position.x);
		PlayerPrefs.SetFloat ("PlayerY", GameObject.Find("spawn").transform.position.y);
		PlayerPrefs.SetFloat ("PlayerZ", GameObject.Find("spawn").transform.position.z);
	}

}