using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinamitePlase : MonoBehaviour {
    public NewWeapon NW;
    public Material Mat;
    public GameObject Location;
    public GameObject BOOM,Collider,Dinamite;
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (NW.Conplite == true)
            {
                StartCoroutine(Destr());
            }
        }
    }
    IEnumerator Destr()
    {
        Dinamite.SetActive(true);
        yield return new WaitForSeconds(2);
        BOOM.SetActive(true);   
        yield return new WaitForSeconds(1);
        Location.GetComponent<Renderer>().material = Mat;
        FindObjectOfType<Inventory>().Dinamite = false;
        Destroy(BOOM.gameObject);
        Destroy(Collider.gameObject,1);
    }
}
