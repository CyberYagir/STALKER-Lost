using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobAnimationControll : MonoBehaviour {
    public MobMove MM;
    public string AnimName;
    void OnTriggerStay2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            MM.Anm.Play(AnimName);
        }
    }
}
