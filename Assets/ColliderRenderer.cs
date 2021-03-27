using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderRenderer : MonoBehaviour {
    public bool Active = false;
    public SpriteRenderer SR;
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }
    void Update () {
		if (Input.GetKeyDown(KeyCode.F7))
        {
            Active = !Active;
            SR.enabled = Active;
        }
	}
}
