using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastMission : MonoBehaviour {
    public bool Conplite;
    public GameObject ToActive;
    public SpriteRenderer SR;
    public Sprite DeadSprite;
    public RuntimeAnimatorController MutenControll;
    public GameObject Pl;
    public GameObject NextLocation;
    public InfoText text;

    [TextArea]
    public string Q7Eng, Q7Rus;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (Conplite == false)
            {
                ToActive.SetActive(true);
                Player.GetComponent<PlayerController>().enabled = false;
                Player.GetComponent<Shoot>().enabled = false;
                Conplite = true;
            }
        }
    }
    public void Q7Objective()
    {
        FindObjectOfType<GameManager>().questText.RusText = Q7Rus;
        FindObjectOfType<GameManager>().questText.EngText = Q7Eng;
    }
    public void End()
    {
        Pl.GetComponent<Animator>().runtimeAnimatorController = MutenControll;
        SR.sprite = DeadSprite;
        SR.transform.localScale = new Vector2(SR.transform.localScale.x, SR.transform.localScale.y / 2);
        SR.transform.rotation = Quaternion.Euler(0, 0, 90);
        NextLocation.SetActive(true);
        Pl.GetComponent<Shoot>().enabled = false;
        Pl.GetComponent<Run>().Walk = Pl.GetComponent<Run>().Walk * 2;
        Pl.GetComponent<Run>().RunSpeed = Pl.GetComponent<Run>().RunSpeed * 2;
        text.Name = "[Мутень Дмитрий Огурец]";
        Q7Objective();
    }
}
