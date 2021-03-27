using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxrannik : MonoBehaviour {
    public VolyaQuest VQ;
    public Quest3 Q3;
    public bool GetIt = false;
    public EntityMove MM;
    public GameObject CheckMark, BOOM;
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.transform.tag == "Player")
        {
            if (VQ.Conplite == true)
            {
                if (GetIt == false)
                {
                    MM.enabled = false;
                    Player.GetComponent<Inventory>().Dinamite = false;
                    StartCoroutine(CheckMarkC());
                    GetIt = true;
                }
            }
        }
    }
    IEnumerator CheckMarkC()
    {
        CheckMark.SetActive(true);
        yield return new WaitForSeconds(5);
        Destroy(CheckMark.gameObject);
        BOOM.SetActive(true);
        yield return new WaitForSeconds(1);
        VQ.enabled = false;
        Q3.enabled = true;
        Destroy(gameObject);

    }
}
