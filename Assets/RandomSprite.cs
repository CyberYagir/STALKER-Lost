using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour {
    public SpriteRenderer SR;
    public Sprite[] Sprites;
	// Update is called once per frame
	void FixedUpdate () {
        SR.sprite = Sprites[Random.Range(0, Sprites.Length)];
	}
}
