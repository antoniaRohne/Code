﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void StoryOverview(){
		SceneManager.LoadScene ("storyInterpretation");
	}

	public void Sources(){
		SceneManager.LoadScene ("sources");
	}

    public void LevelSelect()
    {
        SceneManager.LoadScene("levelSelect");
    }

    public void Quit(){
		Application.Quit ();
	}
}
