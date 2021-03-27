using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabarQuest : MonoBehaviour
{
    public bool Conplite,End,Vzat;
    public GameObject ToActive, ToActive2;
    public GameObject Player;
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (Conplite == false)
            {
                Vzat = true;
                Player.GetComponent<PlayerController>().enabled = false;
                ToActive.SetActive(true);
            }
            else
            {
                Player.GetComponent<PlayerController>().enabled = false;
                ToActive2.SetActive(true);
                if (End == false)
                {
                    Player.GetComponent<Inventory>().Money += 4000;
                    End = true;
                }
            }
        }
    }
}
