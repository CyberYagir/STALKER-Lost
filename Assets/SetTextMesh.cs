using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTextMesh : MonoBehaviour {

    public TextMesh Text;
    [TextArea]
    public string RusText;
    [TextArea]
    public string EngText;
    SaveLoadLanguage SLL;

    private void Start()
    {
        SLL = FindObjectOfType<SaveLoadLanguage>();
    }

    void Update()
    {
        if (SLL.lastLanguage == true)
        {
            Text.text = RusText;
        }

        if (SLL.lastLanguage == false)
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
