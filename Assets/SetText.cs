using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetText : MonoBehaviour {
    public Text Text;
    [TextArea]
    public string RusText;
    [TextArea]
    public string EngText;
    public GameManager GameManager;

    private void Start()
    {
        GameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (GameManager.Rus == true)
        {
            Text.text = RusText;
        }

        if (GameManager.Rus == false)
        {
            Text.text = EngText;
        }

    }

    public void SetTextEng(string s)
    {
        EngText = s;
    }
    public void SetTextRu(string s)
    {
        RusText = s;
    }

}
