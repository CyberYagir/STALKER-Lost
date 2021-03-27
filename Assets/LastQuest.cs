using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastQuest : MonoBehaviour
{

    public GazetaDialog GazetaDialog;
    public GameObject ToActive;
    public bool Conplite = false;
    public GameObject point;
    public void Update()
    {
        if (GazetaDialog.END)
        {
            point.active = true;
        }
    }
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (GazetaDialog.END) {
            if (Player.transform.tag == "Player")
            {
                if (Conplite == false)
                {
                    FindObjectOfType<PlayerController>().enabled = false;
                    ToActive.active = true;
                    //Conplite = true;
                }
            }
        }
    }
}
