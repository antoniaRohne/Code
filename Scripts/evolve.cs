using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class evolve : MonoBehaviour {

	public RawImage crawl;
	public RawImage walk;
	public RawImage run;
	public Image e;
	private int counter = 0;
	public Color firstColor;
	public Color secondColor;


	void Start(){
		crawl.color = firstColor;
		walk.color = firstColor;
		run.color = firstColor;
		e.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (counter == 3) {
			crawl.color = secondColor;
		}
		if (counter == 6) {
			walk.color = secondColor;
		}
		if (counter == 9) {
			run.color = secondColor;
			e.enabled = true;
		}
		if (Input.GetKeyDown ("e") && counter >= 9) {
			changeScene ();
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Crystal") {
			counter++;
			Debug.Log ("You have "+counter+" Crystal(s)");
			Destroy (other.gameObject);
		}
	}


	void changeScene()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}


}