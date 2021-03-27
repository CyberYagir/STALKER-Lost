using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltDrop : MonoBehaviour {
    public GameObject Bolt;
	void Update () {
	    if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Instantiate(Bolt, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
        }	
	}

}
