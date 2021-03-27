using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {
    public GameManager Manager;
    public Animator Animator;
    public bool OnStart = true;
    float f;
    void Start()
    {
        f = Random.Range(1, 6);
        StartCoroutine(RandomWait());
    }

    void Update()
    {
        if (OnStart == false)
        {
            if (Manager.Wind == true)
            {
                Animator.enabled = true;
            }
            else
            {
                Animator.enabled = false;
            }
        }
        else
        {
            Animator.enabled = true;
        }
    }
    IEnumerator RandomWait()
    {
        yield return new WaitForSeconds(f);
        OnStart = false;
        print(f);
    }

}
