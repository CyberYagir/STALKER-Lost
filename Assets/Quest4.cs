using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest4 : MonoBehaviour {

    public bool Conplite;
    public GameObject ToActive;
    [TextArea]
    public string Q5Eng, Q5Rus;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (Conplite == false)
            {
                Player.GetComponent<PlayerController>().enabled = false;
                ToActive.SetActive(true);
                Conplite = true;
            }
        }
    }
    public void Q5Objective()
    {
        FindObjectOfType<GameManager>().questText.RusText = Q5Rus;
        FindObjectOfType<GameManager>().questText.EngText = Q5Eng;
    }


}


