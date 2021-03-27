using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : MonoBehaviour
{
    public SpriteRenderer SR;
    public float minDist;
    public void FixedUpdate()
    {
        float dist = Vector2.Distance(transform.position, GameObject.FindObjectOfType<PlayerController>().transform.position);
        if (dist <= minDist)
        {
            SR.enabled = true;
        }
        else
        {
            SR.enabled = false;
        }
    }


    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (Player.GetComponent<Inventory>().Artifact == false)
            {
                Player.GetComponent<Inventory>().Artifact = true;
                Destroy(gameObject);
            }
        }
    }
}
