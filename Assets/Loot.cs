using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour {
    public bool Conserva;
    public bool Aptechka;
    public bool Antiradin;
    public bool Dinamite;
    public bool Artifact;
    public bool Voter;
    public Inventory Invent;


    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (Conserva)
            {
                if (Invent.Conserva == false)
                {
                    Invent.Conserva = true;
                    Destroy(gameObject);
                }
            }
            if (Aptechka)
            {
                if (Invent.Aptechka == false)
                {
                    Invent.Aptechka = true;
                    Destroy(gameObject);
                }
            }
            if (Antiradin)
            {
                if (Invent.Antiradin == false)
                {
                    Invent.Antiradin = true;
                    Destroy(gameObject);
                }
            }
            if (Dinamite)
            {
                if (Invent.Dinamite == false)
                {
                    Invent.Dinamite = true;
                    Destroy(gameObject);
                }
            }
            if (Artifact)
            {
                if (Invent.Artifact == false)
                {
                    Invent.Artifact = true;
                    Destroy(gameObject);
                }
            }
            if (Voter)
            {
                if (Invent.Voter == false)
                {
                    Invent.Voter = true;
                    Destroy(gameObject);
                }
            }
        }
    }
}
