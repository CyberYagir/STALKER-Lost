using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour {
    public bool Buyed;
    public int Value;
    public GameObject Mark;
    public SborVsheh SV;
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (Buyed == false)
            {
                if (SV.Vzyat == true)
                {
                    if (Player.GetComponent<Inventory>().Money >= Value)
                    {
                        Player.GetComponent<Inventory>().Money -= Value;
                        Instantiate(Mark, transform.position, Quaternion.identity, transform);
                        Buyed = true;
                    }
                }
            }
        }
    }
}
