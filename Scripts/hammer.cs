using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hammer : MonoBehaviour {

	public Image img;

	void Start () {
		img.enabled = false;
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		img.enabled = true;
        this.GetComponent<SpriteRenderer>().enabled = false;
    }
}
