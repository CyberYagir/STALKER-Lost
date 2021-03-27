using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otrajatel : MonoBehaviour {
    public float Damage;
    public GameObject dangerText;

    void OnTriggerStay2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            dangerText.SetActive(true);
            Player.GetComponent<Inventory>().Health -= Damage;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dangerText.SetActive(false);
    }
}
