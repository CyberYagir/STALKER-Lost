using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {
    public Inventory Invent;
    public PlayerController PC;
    public float RunSpeed = 0.016f, Walk = 0.008f;
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Invent.Stamina > 0)
            {
                PC.Speed = RunSpeed;
                Invent.Stamina -= 0.05f;
            }
            if (Invent.Stamina <= 0)
            {
                PC.Speed = Walk;
            }
        }
        else
        {
            PC.Speed = Walk;
        }
	}
}
