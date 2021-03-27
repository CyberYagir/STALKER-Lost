using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour {
    public bool Conserva;
    public bool Aptechka;
    public bool Antiradin;
    public bool Dinamite;
    public bool Artifact;
    public bool Voter;
    public Inventory Invent;
    public void Use()
    {
        if (Conserva)
        {
            Invent.Hunger -= 30f;
            Invent.Health += 50;
            Invent.Conserva = false;
        }
        if (Voter)
        {
            Invent.Hunger -= 20f;
            Invent.Health += 20;
            Invent.Voter = false;
        }
        if (Antiradin)
        {
            Invent.Health += 100;
            Invent.Antiradin = false;
        }
        if (Aptechka)
        {
            Invent.Health += 100;
            Invent.Aptechka = false;
        }
        if (Artifact)
        {
            Invent.Health += 100;
            Invent.Hunger += 0;
            Invent.Stamina += 100;
            Invent.Artifact = false;
        }
    }
}
