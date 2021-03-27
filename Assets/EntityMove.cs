using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMove : MonoBehaviour {
    public bool Up, Down, Left, Right;
    public Animator Anm;
    public float Speed;
    void Start()
    {
        if (Anm == null)
        {
            Anm = GetComponent<Animator>();
        }
        int g = Random.Range(0, 4);

        if (g == 0)
        {
            Up = true;
            Down = false;
            Left = false;
            Right = false;
        }
        if (g == 1)
        {
            Up = false;
            Down = true;
            Left = false;
            Right = false;
        }
        if (g == 2)
        {
            Up = false;
            Down = false;
            Left = true;
            Right = false;
        }
        if ((g == 3) || (g == 4))
        {
            Up = false;
            Down = false;
            Left = false;
            Right = true;

        }
    }
    void FixedUpdate()
    {
        StartCoroutine(NextMove());
        if (Up)
        {
            Anm.Play("Up");
            transform.Translate(Vector2.up * Speed);
        }
        if (Down)
        {
            Anm.Play("Down");
            transform.Translate(Vector2.down * Speed);
        }
        if (Left)
        {
            Anm.Play("Left");
            transform.Translate(Vector2.left * Speed);
        }
        if (Right)
        {
            Anm.Play("Right");
            transform.Translate(Vector2.right * Speed);
        }
    }
    IEnumerator NextMove()
    {
        yield return new WaitForSeconds(5);
        int g = Random.Range(0, 4);

        if (g == 0)
        {
            Up = true;
            Down = false;
            Left = false;
            Right = false;
        }
        if (g == 1)
        {
            Up = false;
            Down = true;
            Left = false;
            Right = false;
        }
        if (g == 2)
        {
            Up = false;
            Down = false;
            Left = true;
            Right = false;
        }
        if ((g == 3) || (g == 4))
        {
            Up = false;
            Down = false;
            Left = false;
            Right = true;

        }
        StopAllCoroutines();
    }
}
