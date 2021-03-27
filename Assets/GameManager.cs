using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
    public GameObject StartLocation, Tutorial;
    public GameObject[] Locations;
    public GameObject[] HideWeapon;
    public SetText questText;
    public bool Rus = true;
    public bool Wind = false;
    public GameObject AttackSound;
    public void Start()
    {
        Tutorial.SetActive(true);
        FindObjectOfType<PlayerController>().enabled = false;
        ColliderRenderer[] g = FindObjectsOfType<ColliderRenderer>();
        for (int i = 0; i < g.Length; i++)
        {
            g[i].GetComponent<SpriteRenderer>().enabled = false;
        }
        for (int i = 0; i < Locations.Length; i++)
        {
            Locations[i].SetActive(false);
        }
        StartLocation.SetActive(true);
        Return();
    }
    void Return()
    {
        StopAllCoroutines();
        StartCoroutine(WindStart());
    }
    IEnumerator WindStart()
    {
        yield return new WaitForSeconds(Random.Range(0, 10));
        Wind = !Wind;
        Return();
    }
    public void LoadLevel(string name)
    {
        Application.LoadLevel(name);
    }
}
