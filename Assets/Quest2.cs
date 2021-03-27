using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest2 : MonoBehaviour {
    public bool Conplite;
    public GameObject ToActive;
    public Inventory Invent;
    public Shop shop;
    bool artifactExist = false;
    [TextArea]
    public string Q3Eng, Q3Rus;

    private void  FixedUpdate()
    {
        if (!Conplite)
        {
            if (Invent.Artifact == true)
            {
                artifactExist = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (Conplite == false)
            {
                if (artifactExist)
                {
                    if (shop.artifactSelled)
                    {
                        if (Invent.Money > 0)
                        {
                            Player.GetComponent<PlayerController>().enabled = false;
                            ToActive.SetActive(true);
                            Conplite = true;
                        }
                    }
                }
            }
        }
    }

    public void SetQ3Objective()
    {
        FindObjectOfType<GameManager>().questText.RusText = Q3Rus;
        FindObjectOfType<GameManager>().questText.EngText = Q3Eng;
    }
}
