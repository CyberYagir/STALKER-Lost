using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anomaly : MonoBehaviour {
    public bool InTrigger = false;
    public bool SubsructHP = true;
    public bool PermanentSubstruct = false;
    void FixedUpdate()
    {
        if (InTrigger == true)
        {
            if (SubsructHP == true)
            {
                FindObjectOfType<Inventory>().Health -= 0.4f;
            }
            if (PermanentSubstruct == true)
            {
                FindObjectOfType<Inventory>().Health -= 0.4f;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            InTrigger = true;
        }
        if (Player.transform.tag == "Bolt")
        {
            SubsructHP = false;
        }
    }
    void OnTriggerExit2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            InTrigger = false;
        }
        if (Player.transform.tag == "Bolt")
        {
            SubsructHP = true;
        }
    }
}
