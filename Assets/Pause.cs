using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    [Header("ResumeButton")]
    public bool ResumeButton;
    public Pause Paus;
    [Header("All")]
    public GameObject PauseManu;
    public List<Canvas> Canvases = new List<Canvas>();
    void Start()
    {
        GameResume();
    }

    void Update()
    {
        if (ResumeButton == false)
        {
            if (Time.timeScale == 0.0001f)
            {
                PauseManu.gameObject.SetActive(true);
            }
            else
            {
                PauseManu.gameObject.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Time.timeScale == 1)
                {
                    GamePause();
                }
                else
                {
                    GameResume();
                }
            }
        }
    }
    void OnMouseDown()
    {
        if (ResumeButton == true)
        {
            Paus.GameResume();
        }
    }
    public void GamePause()
    {
        Canvases = new List<Canvas>();
        Canvas[] f = FindObjectsOfType<Canvas>();
        for (int i = 0; i <f.Length; i++)
        {
            Canvases.Add(f[i]);
            Canvases[i].gameObject.SetActive(false);
        }
        Time.timeScale = 0.0001f;
    }
    public void GameResume()
    {
        for (int i = 0; i < Canvases.Count; i++)
        {
            Canvases[i].gameObject.SetActive(true);
        }
        Time.timeScale = 1f;
    }
}