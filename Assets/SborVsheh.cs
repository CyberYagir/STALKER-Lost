using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SborVsheh : MonoBehaviour
{
    public LastMission LM;
    public Buy[] Mans;
    public bool Vzyat, End;
    public GameObject ToActive1, ToActive2, ToActive3;
    int all;
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (End == false)
            {
                if (LM.Conplite == true)
                {
                    if (Vzyat == true)
                    {
                        all = 0;
                        for (int i = 0; i < Mans.Length; i++)
                        {
                            if (Mans[i].Buyed == true)
                            {
                                all++;
                            }
                        }
                        if (all >= Mans.Length)
                        {
                            ToActive3.SetActive(true);
                            Player.GetComponent<PlayerController>().enabled = false;
                            End = true;
                        }
                        else
                        {
                            ToActive2.SetActive(true);
                            Player.GetComponent<PlayerController>().enabled = false;
                        }
                    }
                    if (Vzyat == false)
                    {
                        ToActive1.SetActive(true);
                        Player.GetComponent<PlayerController>().enabled = false;
                        Vzyat = true;
                    }

                }
            }
        }
    }
}
