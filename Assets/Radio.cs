using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour {
    public AudioClip[] Clips;
    public AudioSource Sourse;
	void Update () {
		if (Sourse.isPlaying == false)
        {
            Sourse.PlayOneShot(Clips[Random.Range(0, Clips.Length)]);
        }
	}
}
