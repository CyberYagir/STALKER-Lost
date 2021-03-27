using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest3 : MonoBehaviour {
    public bool Conplite;
    public GameObject ToActive;
    public Animator Anm;
    public GameObject Player;
    public GameObject ThisLocation,NextLocation;
    public bool SetPos = false;
    public VolyaQuest VQ;
    public Oxrannik oxrannik;
    [TextArea]
    public string Q4Eng, Q4Rus;

    public void Update()
    {
        if (SetPos)
        {
            Player.transform.position = transform.position;
        }
    }

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (VQ.Conplite == true)
            {
                if (oxrannik.GetIt || oxrannik == null)
                {
                    if (Conplite == false)
                    {
                        Player.GetComponent<PlayerController>().enabled = false;
                        ToActive.SetActive(true);
                        Conplite = true;
                    }
                }
            }
        }
    }
    public void StartDemo(GameObject NextLocation)
    {
        StartCoroutine(OffThisLocation());
        StartCoroutine(End());
        Player.transform.position = transform.position;
        Player.transform.parent = transform;
        Player.GetComponent<Rigidbody2D>().isKinematic = true;
        Player.GetComponent<BoxCollider2D>().enabled = false;
        SetPos = true;
        Anm.enabled = true;
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(2.35f);
        Player.transform.parent = null;
        SetPos = false;
        NextLocation.SetActive(true);
        Player.GetComponent<Rigidbody2D>().isKinematic = false;
        Player.GetComponent<PlayerController>().enabled = true;
        Player.GetComponent<BoxCollider2D>().enabled = true;
        FindObjectOfType<GameManager>().questText.RusText = Q4Rus;
        FindObjectOfType<GameManager>().questText.EngText = Q4Eng;
    }
    IEnumerator OffThisLocation()
    {
        yield return new WaitForSeconds(1);
        NextLocation.SetActive(true);
        ThisLocation.SetActive(false);
    }
}
