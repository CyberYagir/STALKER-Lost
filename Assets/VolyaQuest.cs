using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolyaQuest : MonoBehaviour {
    public bool Conplite;
    public GameObject ToActive;
    public GameObject Player;
    public Quest2 Q2;
    [TextArea]
    public string Q4Eng, Q4Rus;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (Q2.Conplite == true)
            {
                if (Conplite == false)
                {
                    Player.GetComponent<PlayerController>().enabled = false;
                    Player.GetComponent<Inventory>().Dinamite = true;
                    ToActive.SetActive(true);
                    Conplite = true;
                }
            }
        }
    }
    public void Q4Objective()
    {
        FindObjectOfType<GameManager>().questText.RusText = Q4Rus;
        FindObjectOfType<GameManager>().questText.EngText = Q4Eng;
    }
}
