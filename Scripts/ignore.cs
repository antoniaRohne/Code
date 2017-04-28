using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignore : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D collision)
    {
        this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
      
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        this.gameObject.GetComponent<PolygonCollider2D>().enabled = true;

    }

}
