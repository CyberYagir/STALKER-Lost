using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainBurnerHP : MonoBehaviour {
    public GameObject[] Otrajateli;
    public Sprite Full, Polovina, Zero;
    public GameObject Fire;
    public int Hp = 100;
    public SpriteRenderer SR;
    void Update () {
		if (Hp >= 200)
        {
            if (SR.sprite != Full)
            {
                SR.sprite = Full;
            }
        }
        if (Hp <= 100)
        {
            if (SR.sprite != Polovina)
            {
                SR.sprite = Polovina;
            }
        }
        if (Hp <= 0)
        {
            if (SR.sprite != Zero)
            {
                for(int i = 0; i < Otrajateli.Length; i++)
                {
                    Otrajateli[i].GetComponentInChildren<ParticleSystem>().enableEmission = false;
                    Otrajateli[i].GetComponent<Otrajatel>().enabled = false;
                    Otrajateli[i].GetComponent<BoxCollider2D>().enabled = false;
                }
                Fire.SetActive(true);
                SR.sprite = Zero;
            }
        }
    }
}
