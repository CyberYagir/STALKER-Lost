using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour {
    public float Speed;
    public float Time;
    void Start()
    {
        StartCoroutine(Wait());
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * Speed);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Time);
        Speed = 0;
        yield return new WaitForSeconds(Time*5);
        Destroy(gameObject);
    }
}
