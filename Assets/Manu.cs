using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manu : MonoBehaviour {
    public bool Play,Exit,Options,Back,SetGraphic,SetResolution,FullScreen,Save;
    public GameObject Fon;
    [Header("PlayButton")]
    public GameObject Loading;
    public string WorldName;
    [Header("Options")]
    public GameObject OptionsLayer;
    public GameObject[] ToEnabled;
    [Header("Back")]
    public GameObject ToActive;
    public GameObject ToDisable;
    [Header("Graphics Indicator")]
    public Material Low;
    public Material Medium;
    public Material Hight;
    public GameObject Indicator;
    public int Quatly;
    [Header("Resolution")]
    public int X;
    public int Y;
    [Header("FullScreen")]
    public bool Full;
    [Header("SaveLanguage")]
    public bool Rus;
    public bool SaveAll;
    public SaveLoadLanguage SLL;

    void Start()
    {
        QualitySettings.SetQualityLevel(0);
    }
    void Awake()
    {
        Fon.SetActive(false);
    }
    void OnMouseDown()
    {
        if (Play == true)
        {
            Loading.SetActive(true);
            Application.LoadLevel(WorldName);
        }
        if (Exit == true)
        {
            Application.Quit();
        }
        if (Options == true)
        {
            OptionsLayer.SetActive(true);
            for (int i = 0; i < ToEnabled.Length; i++)
            {
                ToEnabled[i].SetActive(!ToEnabled[i].active);
            }
        }
        if (Back == true)
        {
            ToActive.SetActive(true);
            ToDisable.SetActive(false);
        }
        if (SetResolution == true)
        {
            SetRes();
        }
        if (SetGraphic == true)
        {
            NewQuatly();
        }
        if (Save == true)
        {
            SLL.Save(Rus, QualitySettings.GetQualityLevel());
        }
        if (SaveAll == true)
        {
            SLL.Save(SLL.lastLanguage, QualitySettings.GetQualityLevel());
        }
        if (FullScreen)
        {
            if (Screen.fullScreenMode == FullScreenMode.Windowed)
            {
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            }else
            if (Screen.fullScreenMode == FullScreenMode.FullScreenWindow)
            {
                Screen.fullScreenMode = FullScreenMode.Windowed;
            }
            else
            {
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            }
        }
    }
    void OnMouseEnter()
    {
        Fon.SetActive(true);
    }
    void OnMouseExit()
    {
        Fon.SetActive(false);
    }
    void NewQuatly()
    {
        QualitySettings.SetQualityLevel(Quatly);
        int g = QualitySettings.GetQualityLevel();
        if (g == 0)
        {
            Indicator.GetComponent<Renderer>().material = Low;
        }
        if (g == 1)
        {
            Indicator.GetComponent<Renderer>().material = Medium;
        }
        if (g == 2)
        {
            Indicator.GetComponent<Renderer>().material = Hight;
        }
    }
    void SetRes()
    {
        Screen.SetResolution(X, Y, true);
    }
    
}
