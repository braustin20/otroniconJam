using UnityEngine;
using System.Collections;

public class CollisionTriggerSpawnTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider collision){
		Debug.Log ("I AM INSIDE");

		//Change collision to whatever causes the objects to spawn. You will need to hardcode the location of the spawning rocks.
		//otherwise create game objects for spawn locations.
		if(collision.gameObject.tag == "Player"){
		Debug.Log ("HIT");
		Instantiate(GameObject.Find ("rock"), new Vector3(Random.Range(6.0f,12.0f),
		                            1,
		                            Random.Range(15.0f,21.0f)),
		            Quaternion.identity);

		}
	}
}
