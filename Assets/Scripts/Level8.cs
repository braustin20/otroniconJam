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

		currentPos = new Vector2(-10, -1);

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
	
	public void PlatformTrigger(Vector3 pos) {

		Vector2 temp = new Vector2((int)(pos.x / size), (int)(pos.z / size));

		if (currentPos.x != -10){

			Grow(new Vector2(pos.x - temp.x, pos.y - temp.y));

		}
		currentPos = temp;
	}

	void Grow(Vector2 index) {

	}
}
