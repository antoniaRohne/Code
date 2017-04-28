using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroom : MonoBehaviour {

	public static bool fly;
	private GameObject Player;

	void Start(){
		Player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.UpArrow)&& fly)
			Player.GetComponent<Rigidbody2D> ().gravityScale = -1;
		if(Input.GetKeyUp(KeyCode.UpArrow)&& fly)
			Player.GetComponent<Rigidbody2D> ().gravityScale = 3;
	}

	void OnTriggerEnter2D(Collider2D other){
		fly = true;
        StartCoroutine(Respawn());
		
	}

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(20);
        this.GetComponent<SpriteRenderer>().enabled = true;
    }
}
