using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassScript : MonoBehaviour {
    public SpriteRenderer Sprite;
    public Sprite[] Sprites;
    void Start()
    {
        int g = QualitySettings.GetQualityLevel();
        if (g == 0)
        {
            Destroy(gameObject);
        }
        if (g == 1)
        {
            int f = Random.Range(0, 3);
            if (f != 1)
            {
                Destroy(gameObject);
            }
        }
    }

    void FixedUpdate()
    {
        StartCoroutine(Wait());
    }
    void Return()
    {
        StopAllCoroutines();
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.2f);
        Sprite.sprite = Sprites[Random.Range(0, Sprites.Length)];
        Return();
    }
}
