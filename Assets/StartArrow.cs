using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartArrow : MonoBehaviour {
    public GameObject Object,Player;
    public GameObject Arrow, Point;
    public Vector3 Offset;
    void Update() {
        if (Object == null)
        {
            Destroy(gameObject);
        }
		if(Object != null)
        {
            Arrow.transform.position = Player.transform.position;
            Vector3 diff = Point.transform.position - Arrow.transform.position;
            diff.Normalize();

            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            Arrow.transform.rotation = Quaternion.Euler(0f, 0f, rot_z);
        }
	}
}
