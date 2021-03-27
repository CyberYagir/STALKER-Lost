using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellItem : MonoBehaviour {
    public bool Conserva;
    public bool Aptechka;
    public bool Antiradin;
    public bool Dinamite;
    public bool Artifact;
    public bool Voter;
    public bool PBullets;
    public bool RBullets;
    public Inventory Invent;

    public void Buy(int Cost)
    {
        if (Invent.Money >= Cost)
        {
            if (Conserva)
            {
                if (Invent.Conserva == false)
                {
                    Invent.Money -= Cost;
                    Invent.Conserva = true;
                }
            }
            if (Aptechka)
            {
                if (Invent.Aptechka == false)
                {
                    Invent.Money -= Cost;
                    Invent.Aptechka = true;
                }
            }
            if (Antiradin)
            {
                if (Invent.Antiradin == false)
                {
                    Invent.Money -= Cost;
                    Invent.Antiradin = true;
                }
            }
            if (Dinamite)
            {
                if (Invent.Dinamite == false)
                {
                    Invent.Money -= Cost;
                    Invent.Dinamite = true;
                }
            }
            if (Artifact)
            {
                if (Invent.Artifact == false)
                {
                    Invent.Money -= Cost;
                    Invent.Artifact = true;
                }
            }
            if (Voter)
            {
                if (Invent.Voter == false)
                {
                    Invent.Money -= Cost;
                    Invent.Voter = true;
                }
            }
            if (PBullets)
            {
                Invent.PistolBullets += 20;
                Invent.Money -= Cost;
            }
            if (RBullets)
            {
                Invent.RifleBullets += 100;
                Invent.Money -= Cost;
            }
        }
    }

    public void Sell(int Cost)
    {
        if (Conserva)
        {
            Invent.Money += Cost;
            Invent.Conserva = false;
        }
        if (Aptechka)
        {
            Invent.Money += Cost;
            Invent.Aptechka = false;
        }
        if (Antiradin)
        {
            Invent.Money += Cost;
            Invent.Antiradin = false;
        }
        if (Dinamite)
        {
            Invent.Money += Cost;
            Invent.Dinamite = false;
        }
        if (Artifact)
        {
            FindObjectOfType<Shop>().artifactSelled = true;
            Invent.Money += Cost;
            Invent.Artifact = false;
        }
        if (Voter)
        {
            Invent.Money += Cost;
            Invent.Voter = false;
        }
    }
}
