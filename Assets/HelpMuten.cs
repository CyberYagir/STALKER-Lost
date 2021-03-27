using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMuten : MonoBehaviour {
    public GameObject HelpSprite,ThxSprite;
    public GameObject[] Mobs;
    public int deadCount;
    public bool End;
    void FixedUpdate()
    {
        if (End == false)
        {
            deadCount = 0;
            for (int i = 0; i < Mobs.Length; i++)
            {
                if (Mobs[i] == null)
                {
                    deadCount++;
                }
            }
            if (deadCount == 4)
            {
                HelpSprite.SetActive(false);
                ThxSprite.SetActive(true);
                End = true;
            }
        }
    }
}
