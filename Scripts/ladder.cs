using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour {

	private Animator m_Anim;      


	void Start(){

	}

	void OnTriggerEnter2D(Collider2D Player){

		m_Anim = Player.GetComponent<Animator> ();
		m_Anim.SetBool("ladder",true);
		Player.attachedRigidbody.gravityScale = 0;


	}

	void OnTriggerExit2D(Collider2D Player){
		m_Anim.SetBool("ladder",false);
		Player.attachedRigidbody.gravityScale = 3;
	}
}
