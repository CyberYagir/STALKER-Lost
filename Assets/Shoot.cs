using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public bool Shooted;
    public GameObject Bullet;
    public PlayerMode Mode;
    public Inventory Inventory;
    void Update()
    {
        if (GetComponent<Animator>().runtimeAnimatorController.name == "MutatedMuten")
        {
            Mode.None = true;
            Mode.Pistol = false;
            Mode.Rifle = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
                if (Shooted == false)
                {
                    StopAllCoroutines();
                    if (Mode.Rifle == true)
                    {
                        if (Inventory.RifleBullets > 0)
                        {
                            StartCoroutine(Rifle());
                            Shooted = true;
                        }
                    }
                    if (Mode.Pistol == true)
                    {
                        if (Inventory.PistolBullets > 0)
                        {
                            StartCoroutine(Pistol());
                            Shooted = true;
                        }
                    }
                }
        }
    }
    IEnumerator Rifle()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Instantiate(Bullet,transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
        yield return new WaitForSeconds(0.2f);
        Instantiate(Bullet, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
        yield return new WaitForSeconds(0.2f);
        Instantiate(Bullet, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
        yield return new WaitForSeconds(0.2f);
        Inventory.RifleBullets -= 3;
        Shooted = false;
        StopAllCoroutines();
    }
    IEnumerator Pistol()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Instantiate(Bullet, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
        yield return new WaitForSeconds(0.4f);
        Inventory.PistolBullets -= 1;
        Shooted = false;
        StopAllCoroutines();
    }
}
