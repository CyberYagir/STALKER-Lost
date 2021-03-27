using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillManQuest : MonoBehaviour {
    public bool Conplite, End;
    public GameObject ToActive;
    public GameObject Player;
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (End == false)
            {
                if (Conplite == false)
                {
                    Player.GetComponent<PlayerController>().enabled = false;
                    ToActive.SetActive(true);
                    Conplite = true;
                }
            }
        }
    }
    public void Dead()
    {
        transform.tag = "Untagged";
        transform.rotation = Quaternion.Euler(0, 0, 90);
        transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y / 2);
        Player.GetComponent<Inventory>().Money += 10000;
        Player.GetComponent<Inventory>().MaxHealth = 50;
        End = true;
    }
}
