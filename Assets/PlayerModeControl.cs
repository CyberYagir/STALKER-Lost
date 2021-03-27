using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModeControl : MonoBehaviour {
    public PlayerMode playerMode;
    public Shoot shoot;
    public GameObject n, p,r;
	void FixedUpdate () { 
        if(shoot.enabled == false)
        {
            playerMode.None = true;
            playerMode.Pistol = false;
            playerMode.Rifle = false;
            n.active = true;
            p.active = false;
            r.active = false;
        }

        if ((playerMode.None))
        {
            n.active = true;
            p.active = false;
            r.active = false;
        }
        if (playerMode.Pistol)
        {
            n.active = false;
            p.active = true;
            r.active = false;
        }
        if (playerMode.Rifle)
        {
            n.active = false;
            p.active = false;
            r.active = true;
        }
    }
}
