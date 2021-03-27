using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMode : MonoBehaviour {
    public bool None = true, Pistol, Rifle;
    

    public void ToNone()
    {
        None = true;
        Pistol = false;
        Rifle = false;
    }
    public void ToPistol()
    {
        None = false;
        Pistol = true;
        Rifle = false;
    }
    public void ToRifle()
    {
        None = false;
        Pistol = false;
        Rifle = true; ;
    }
}
