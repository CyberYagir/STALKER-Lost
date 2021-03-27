using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SientistArmor : MonoBehaviour {
    public Quest4 Q4;
    public GameObject ToActive;
    public RuntimeAnimatorController NewAnimator;
    public bool Conplite,End;
    public GameObject Player;

    [TextArea]
    public string Q6Eng, Q6Rus;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (Q4.Conplite == true)
            {
                if (End == false)
                {
                    Player.GetComponent<PlayerController>().enabled = false;
                    ToActive.SetActive(true);
                    Conplite = true;
                }
            }
        }
    }
    public void Q6Objective()
    {
        FindObjectOfType<GameManager>().questText.RusText = Q6Rus;
        FindObjectOfType<GameManager>().questText.EngText = Q6Eng;
    }
    public void NewArmorAdd()
    {
        Player.GetComponent<Animator>().runtimeAnimatorController = NewAnimator;
        Player.GetComponent<Inventory>().RifleBullets += 200;
        Player.GetComponent<Inventory>().PistolBullets += 150;
        Player.GetComponent<BoxCollider2D>().offset = new Vector2(0, -0.15f);
        End = true;
    }
}
