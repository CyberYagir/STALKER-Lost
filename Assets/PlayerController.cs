using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float Speed;
    public Animator Anim;
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.W))
        {
            Anim.Play("Up");
            transform.Translate(Vector2.up * Speed);
        }else
        if (Input.GetKey(KeyCode.S))
        {
            Anim.Play("Down");
            transform.Translate(Vector2.down * Speed);
        }
        else
        if (Input.GetKey(KeyCode.A))
        {
            Anim.Play("Left");
            transform.Translate(Vector2.left * Speed);
        }else
        if (Input.GetKey(KeyCode.D))
        {
            Anim.Play("Right");
            transform.Translate(Vector2.right * Speed);
        }
        else
        {
            Anim.Play("Idle");
        }


    }
}
