using UnityEngine;
using System.Collections;

public class Level8: MonoBehaviour {

	public GameObject PlatformPrefab;

	public int gridSize;

	Vector2 currentPos;

	GameObject[ , ] grid;

	float size;
	// Use this for initialization
	void Start () {

		//currentPos = null;

		size = PlatformPrefab.transform.localScale.x + 0.1f;

		grid = new GameObject[gridSize, gridSize];

		for(int i = 0; i < gridSize; i++) {
			for (int j = 0; j < gridSize; j++) {
				grid[i, j] = (GameObject)Instantiate(PlatformPrefab, new Vector3(i * size, 0, j * size), transform.rotation);
				grid[i, j].AddComponent<Level8Platforms>();
				Destroy (grid[i, j].GetComponent<tileFallingBehavior>());
			}
		}
	}
	
	// Update is called once per frameb
	void Update () {
	
	}

	public void PlatformTrigger(Vector3 pos) {


		if (currentPos != null){

		}




	}
}
