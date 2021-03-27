using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazetaDialog : MonoBehaviour
{
    public DestroyZabor DZ;
    public GameObject ToActive1,ToActive2;
    public GameObject[] Skafs;
    public bool Conplite, END;
    int all = 0;
    [TextArea]
    public string QEng, QRus;

    void Start()
    {
        for (int i = 0; i < Skafs.Length; i++)
        {
            if (Skafs[i] != null)
            {
                Skafs[i].SetActive(false);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (END == false)
        {
            if (DZ.Ended == true)
            {
                if (Conplite == false)
                {
                    for (int i = 0; i < Skafs.Length; i++)
                    {
                        if (Skafs[i] != null)
                        {
                            Skafs[i].SetActive(true);
                        }
                    }
                    Player.GetComponent<PlayerController>().enabled = false;
                    ToActive1.SetActive(true);
                    FindObjectOfType<GameManager>().questText.RusText = QEng;
                    FindObjectOfType<GameManager>().questText.EngText = QRus;
                    Conplite = true;
                }
                if (Conplite == true)
                {
                    all = 0;
                    for (int i = 0; i < Skafs.Length; i++)
                    {
                        if (Skafs[i] == null)
                        {
                            all += 1;
                        }
                    }
                    if (all == Skafs.Length)
                    {
                        Player.GetComponent<PlayerController>().enabled = false;
                        ToActive2.SetActive(true);
                        END = true;
                    }
                }
            }
        }
    }
    public void NewCollider(BoxCollider2D g)
    {
        g.GetComponent<BoxCollider2D>().size = new Vector2(0.1212893f, 0.03917558f);
        g.GetComponent<BoxCollider2D>().offset = new Vector2(0, -0.05F);
    }
}
