using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

	public GameObject tel;

	public float shift; 
	private Vector3 pos;


	void OnTriggerEnter2D(Collider2D other){
		pos = tel.transform.position;
		pos.x = pos.x - shift;
		other.transform.position = pos;
	}
}
