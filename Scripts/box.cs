using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class box : MonoBehaviour {

	private float delay = 2.0f;

	void Start(){
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.collider.tag == "Player") {
			StartCoroutine (Fall());
		}
	}

	IEnumerator Fall(){
		yield return new WaitForSeconds (delay);
		DestroyObject (this.gameObject);
	}

}