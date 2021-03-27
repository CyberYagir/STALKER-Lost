using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPIndicator : MonoBehaviour {
    public RectTransform IMG;
    public Inventory Invent;

    public bool Hp = true,Hunger,Stamina;

    void Update()
    {
        if (Hp)
        {
            IMG.localScale = new Vector2((Invent.Health / 10), IMG.localScale.y);
        }
        if (Hunger)
        {
            IMG.localScale = new Vector2((Invent.Hunger / 10), IMG.localScale.y);
        }
        if (Stamina)
        {
            IMG.localScale = new Vector2((Invent.Stamina / 10), IMG.localScale.y);
        }
    }
}
