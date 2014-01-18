using UnityEngine;
using System.Collections;

public class Level7: MonoBehaviour {

	public GameObject PlatformPrefab;

	public int gridSize;

	GameObject[ , ] grid;

	float size;
	// Use this for initialization
	void Start () {

		size = PlatformPrefab.transform.localScale.x + 0.1f;

		grid = new GameObject[gridSize, gridSize];

		for(int i = 0; i < gridSize; i++) {
			for (int j = 0; j < gridSize; j++) {
				grid[i, j] = (GameObject)Instantiate(PlatformPrefab, new Vector3(i * size, 0, j * size), transform.rotation);
				grid[i, j].AddComponent<Level7Platforms>();
				Destroy (grid[i, j].GetComponent<tileFallingBehavior>());
			}
		}

	}
	
	// Update is called once per frameb
	void Update () {
	
	}

	public void PlatformTrigger(Vector3 pos) {

		if (pos.z / size < 9) 
			grid[(int)(pos.x / size),(int)(pos.z / size) + 1].GetComponent<Level7Platforms>().Rise (1.5f);
		if (pos.z/size < 8) {
			grid[(int)(pos.x / size),(int)(pos.z / size) + 2].GetComponent<Level7Platforms>().Rise (3f);
			if (pos.x / size > 0) 
				grid[(int)(pos.x / size) - 1,(int)(pos.z / size) + 2].GetComponent<Level7Platforms>().Rise (1.5f);
			if (pos.x / size < 9)
				grid[(int)(pos.x / size) + 1,(int)(pos.z / size) + 2].GetComponent<Level7Platforms>().Rise (1.5f);

		}


	}
}
