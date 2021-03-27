using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float Speed;
    public int Damage = 5;
	void FixedUpdate () {
        transform.Translate(Vector3.right * Speed);
        Destroy(gameObject,10);
    }
    void OnTriggerEnter2D(Collider2D Mob)
    {
        if (Mob.transform.tag == "Mob")
        {
            if (Mob.isTrigger == false)
            {
                Mob.GetComponent<MobPropites>().HP -= Damage;
                Destroy(gameObject);
            }
        }
        if (Mob.transform.tag == "BrainBurner")
        {
            if (Mob.isTrigger == false)
            {
                Mob.GetComponent<BrainBurnerHP>().Hp -= Damage;
                Destroy(gameObject);
            }
        }
        if (Mob.transform.tag == "Collider")
        {
            Destroy(gameObject);
        }
        if (Mob.transform.tag == "Suicide")
        {
            KillManQuest f = Mob.GetComponent<KillManQuest>();
            if (f.Conplite == true)
            {
                f.Dead();
            }
        }
    }
}
