using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabarTree : MonoBehaviour
{
    public GameObject Checker;
    public HabarQuest HQ;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (HQ.Vzat == true)
            {
                Checker.SetActive(true);
                HQ.Conplite = true;
            }
        }
    }
}
