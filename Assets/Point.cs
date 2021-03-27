using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
    public Sientist Sientist;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            Sientist.ChackpointsCheck++;
            Destroy(gameObject);
        }
    }
}
