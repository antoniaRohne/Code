using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stoneWall : MonoBehaviour {

	public Image ham;

	void OnTriggerStay2D(Collider2D other){
		if (Input.GetKey (KeyCode.Mouse0) && ham.enabled) {
			DestroyObject (this.gameObject);
		}
	}

}
