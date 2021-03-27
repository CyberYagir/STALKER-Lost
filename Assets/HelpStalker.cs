using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpStalker : MonoBehaviour {
    public GameObject ToActive1, ToActive2;
    public GameObject[] Mobs;
    public int deadCount;
    public bool End;
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (End == false)
            {
                deadCount = 0;
                for (int i = 0; i < Mobs.Length; i++)
                {
                    if (Mobs[i] == null)
                    {
                        deadCount++;
                    }
                }
                if (deadCount == 3)
                {
                    ToActive2.SetActive(true);
                    Player.GetComponent<Inventory>().Money += 300;
                    Player.GetComponent<Inventory>().RifleBullets += 200;
                    Player.GetComponent<PlayerController>().enabled = false;
                    End = true;
                }
                else
                {
                    Player.GetComponent<PlayerController>().enabled = false;
                    ToActive1.SetActive(true);
                }
            }
        }
    }
}
