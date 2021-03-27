using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTool : MonoBehaviour
{
    public Camera Cam;
    public float Speed;
    void FixedUpdate()
    {
        if (Input.GetKey("="))
        {
            Cam.orthographicSize += Speed;
        }
        if (Input.GetKey("-"))
        {
            if (Cam.orthographicSize > 0.1f)
            {
                Cam.orthographicSize -= Speed;
            }
        }
    }
}
