using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobPropites : MonoBehaviour {
    public float HP = 100;  

    public void LateUpdate()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
