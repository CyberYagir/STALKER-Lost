    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour {
    public GameObject UI;
    public GameObject BookButton;
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            UI.SetActive(true);
            BookButton.SetActive(true);
            Destroy(gameObject);
        }
    }
}
