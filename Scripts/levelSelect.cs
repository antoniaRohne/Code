using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour {

    public void Crawl()
    {
        SceneManager.LoadScene("sequence1");
    }
    public void Walk()
    {
        SceneManager.LoadScene("sequence2");
    }
    public void Run()
    {
        SceneManager.LoadScene("sequence3");
    }
}
