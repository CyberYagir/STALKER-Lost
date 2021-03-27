using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfoText : MonoBehaviour {
    public Inventory Inv;
    public GameManager GM;
    public Text Text;
    public string Name = "[Сталкер КОля Конь]";
    void Update()
    {
        if (GM.Rus == true)
        {
            Text.text = "Статы:" + "\n" +
                Name + ": Винтовка:" + Inv.RifleBullets + " Пистолет:" + Inv.PistolBullets + " Гривни:" + Inv.Money + "\n" +
                "  Здоровье:" + Mathf.RoundToInt(Inv.Health) + "/100" + "\n" +
                "  Голод:" + Mathf.RoundToInt(Inv.Hunger) + "/100" + "\n" +
                "  Усталость:" + Mathf.RoundToInt(Inv.Stamina) + "/100" + "\n";
        }
        if (GM.Rus == false)
        {
            Text.text = "Stats:" + "\n" +
                Name + ": Rifle:" + Inv.RifleBullets + " Pistol:" + Inv.PistolBullets + " Money:" + Inv.Money + "\n" +
                "  Health:" + Mathf.RoundToInt(Inv.Health) + "/100" + "\n" +
                "  Hunger:" + Mathf.RoundToInt(Inv.Hunger) + "/100" + "\n" +
                "  Stamina:" + Mathf.RoundToInt(Inv.Stamina) + "/100" + "\n";
        }
    }
}
