using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInManu : MonoBehaviour
{
    public float Speed;
    public float X;
    void Update()
    {
        X = (Input.GetAxisRaw("Mouse X"));

        if (0 > X)
        {
            transform.Translate(Vector2.right * Speed);
        }
        if (0 < X)
        {
            transform.Translate(Vector2.left * Speed);
        }
    }
}
