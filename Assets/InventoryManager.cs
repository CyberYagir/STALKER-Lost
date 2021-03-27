using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {
    public Inventory Inv;
    public GameObject RifleBullets;
    public GameObject PistolBullets;
    [Header("Usable")]
    public GameObject Conserva;
    public GameObject Aptechka;
    public GameObject Antiradin;
    public GameObject Dinamite;
    public GameObject Artifact;
    public GameObject Voter;

    void Update () {
        Conserva.SetActive(Inv.Conserva);
        Aptechka.SetActive(Inv.Aptechka);
        Antiradin.SetActive(Inv.Antiradin);
        Dinamite.SetActive(Inv.Dinamite);
        Artifact.SetActive(Inv.Artifact);
        Voter.SetActive(Inv.Voter);
        if (Inv.RifleBullets > 0)
        {
            RifleBullets.SetActive(true);
        }
        else
        {
            RifleBullets.SetActive(false);
        }

        if (Inv.PistolBullets > 0)
        {
            PistolBullets.SetActive(true);
        }
        else
        {
            PistolBullets.SetActive(false);
        }

    }
}
