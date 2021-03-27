using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialog : MonoBehaviour {
    public GameObject ActivateObject;
    public GameManager Manager;
    public bool Talk = false;
    bool triggered = false;

    GameObject Player;

    private void Update()
    {
        if (triggered)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (Talk == false)
                {
                    if (Player.GetComponent<PlayerMode>().None == true)
                    {
                        Player.GetComponent<PlayerController>().enabled = false;
                        Player.GetComponent<Shoot>().enabled = false;
                        ActivateObject.SetActive(true);
                    }
                    else
                    {
                        Player.GetComponent<PlayerController>().enabled = false;
                        Player.GetComponent<Shoot>().enabled = false;
                        for (int i = 0; i < Manager.HideWeapon.Length; i++)
                        {
                            Manager.HideWeapon[i].SetActive(false);
                        }
                        Manager.HideWeapon[Random.Range(0, Manager.HideWeapon.Length)].SetActive(true);
                    }
                    Talk = true;
                }
            }
        }
        if (ActivateObject.active == false)
        {
            int  g = 0;
            for (int i = 0; i < Manager.HideWeapon.Length; i++)
            {
                if (Manager.HideWeapon[i].active == false){
                    g++;
                }
            }
            if (g == Manager.HideWeapon.Length)
            {
                Talk = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.transform.tag == "Player")
        {
            Player = player.gameObject;
            triggered = true;
        }
    }
    void OnTriggerExit2D()
    {
        triggered = false;
        Talk = false;
    }

}
