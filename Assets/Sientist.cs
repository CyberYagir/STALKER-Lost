using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sientist : MonoBehaviour {
    public int ChackpointsCheck = 0;
    public GameObject ToActive1, ToActive2;
    public bool Vzal;
    public GameObject[] AllPoints;
    public bool End;
    void FixedUpdate()
    {
        if (End == false)
        {
            if (Vzal == true)
            {
                for (int i = 0; i < AllPoints.Length; i++)
                {
                    if (AllPoints[i] != null)
                    {
                        AllPoints[i].SetActive(true);
                    }
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (End == false)
            {
                if (ChackpointsCheck < 5)
                {
                    Player.GetComponent<PlayerController>().enabled = false;
                    ToActive1.SetActive(true);
                    Vzal = true;
                }
                if (ChackpointsCheck >= 5)
                {
                    ToActive2.SetActive(true);
                    Player.GetComponent<Inventory>().MaxHealth += 50;
                    Player.GetComponent<Inventory>().Money += 500;
                    Player.GetComponent<Inventory>().Antiradin = true;
                    End = true;
                }
            }
        }
    }
}
