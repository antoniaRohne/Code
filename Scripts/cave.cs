using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cave : MonoBehaviour
{
   
    public GameObject Player;
    private bool isFlipped;
    private bool inCave;
    public Image img;
    public Image mush;
    public GameObject mainTarget;
    private Vector3 pos;


    private void Start()
    {
        img.enabled = false;
        isFlipped = false;
        inCave = false;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (inCave)
        {
            if (Input.GetKey(KeyCode.UpArrow) && !isFlipped)
            {
                isFlipped = true;
                Player.GetComponent<Rigidbody2D>().gravityScale = -3;
                Player.GetComponent<SpriteRenderer>().flipY = true;
            }
            else if (Input.GetKey(KeyCode.DownArrow) && isFlipped)
            {
                isFlipped = false;
                Player.GetComponent<Rigidbody2D>().gravityScale = 3;
                Player.GetComponent<SpriteRenderer>().flipY = false;
            }
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        mushroom.fly = false;
        inCave = true;
        img.enabled = true;
        mush.enabled = false;
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        inCave = false;
        img.enabled = false;
        if (isFlipped)
        {
            isFlipped = false;
            Player.GetComponent<Rigidbody2D>().gravityScale = 3;
            Player.GetComponent<SpriteRenderer>().flipY = false;
        }
    }
}
