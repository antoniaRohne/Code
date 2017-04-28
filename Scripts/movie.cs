using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movie : MonoBehaviour {

    public MovieTexture clip;
	// Use this for initialization
	void Start () {
        clip.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if (!clip.isPlaying) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
