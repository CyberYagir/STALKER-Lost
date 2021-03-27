using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToLocation : MonoBehaviour {
    public GameObject Point,NextLocation;
    public bool X, Y;

    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (X == true)
            {
                Player.transform.position = new Vector2(Point.transform.position.x, Player.transform.position.y);

            }
            if (Y == true)
            {
                Player.transform.position = new Vector2(Player.transform.position.x, Point.transform.position.y);

            }
            NextLocation.SetActive(true);
            transform.parent.gameObject.SetActive(false);
        }
    }
}
