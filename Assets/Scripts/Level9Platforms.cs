using UnityEngine;
using System.Collections;

public class Level9Platforms : MonoBehaviour {

	public GameObject next;
	float alpha;
	public float fadeInSpeed;

	void Start() {
		fadeInSpeed = 1500;
		alpha = 0;
		renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, 0);


	}

	public void Go() {

		StartCoroutine("FadeIn");
	}

	IEnumerator FadeIn() {


		while (alpha <= 255){
			renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, alpha / 255);
			alpha += fadeInSpeed * Time.deltaTime;
			yield return 0;
		}
		renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, 255);

		if (next.GetComponent<Level9Platforms>())
			next.GetComponent<Level9Platforms>().StartCoroutine("FadeIn");
		else
			next.GetComponent<Level9>().Reset();
		while (alpha >= 0) {
			renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, alpha / 255);
			alpha -= fadeInSpeed * Time.deltaTime;
			yield return 0;
		}
		renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, 0);

	}
}
