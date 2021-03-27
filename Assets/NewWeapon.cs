using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWeapon : MonoBehaviour
{
    public SientistArmor SA;
    public GameObject ToActive;
    public bool Conplite;
    public GameObject Player;
    public GameObject BulletPrefab;
    [TextArea]
    public string Q6Eng, Q6Rus;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (SA.Conplite == true)
            {
                if (Conplite == false)
                {
                    Player.GetComponent<PlayerController>().enabled = false;
                    ToActive.SetActive(true);
                    NewWeaponAdd();
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
    public void NewWeaponAdd()
    {
        Player.GetComponent<Shoot>().Bullet = BulletPrefab;
        Player.GetComponent<Inventory>().Dinamite = true;
    }
}
