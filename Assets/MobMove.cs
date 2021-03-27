using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMove : MonoBehaviour {
    public bool Up, Down, Left, Right;
    public Animator Anm;
    public float Speed;
    public bool Attack;
    GameObject PlayerObj;
    public GameManager Gm;
    public float Damage = 10;
    public bool Damaged;
    void Start()
    {
        Gm = GameObject.FindObjectOfType<GameManager>();
    }
    void FixedUpdate()
    {
        if (Attack == false)
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
        else
        {
            StopAllCoroutines();
            Up = false;
            Down = false;
            Left = false;
            Right = false;
            AttackFunc(PlayerObj);
        }
    }
    IEnumerator NextMove()
    {
        if (Attack == false)
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
        }
        
        StopAllCoroutines();
    }
    void OnTriggerStay2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            Attack = true;
            StopAllCoroutines();
            PlayerObj = Player.gameObject;
        }
    }
    void OnTriggerExit2D()
    {
        Attack = false;
    }
    void AttackFunc(GameObject Player)
    {
        if (Player.transform.position.y > transform.position.y)
        {
            transform.Translate(Vector2.up * Speed);
        }
        if (Player.transform.position.y < transform.position.y)
        {
            transform.Translate(Vector2.down * Speed);
        }
        if (Player.transform.position.x < transform.position.x)
        {
            transform.Translate(Vector2.left * Speed);
        }
        if (Player.transform.position.x > transform.position.x)
        {
            transform.Translate(Vector2.right * Speed);
        }
        Gm.AttackSound.SetActive(true);
        if (Gm.AttackSound.GetComponent<AudioSource>().isPlaying == false)
        {
           Gm.AttackSound.GetComponent<AudioSource>().Play();
        }
        PlayerObj.GetComponent<Inventory>().Health -= Damage;
    }
}
