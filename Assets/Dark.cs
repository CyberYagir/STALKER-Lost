using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dark : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}