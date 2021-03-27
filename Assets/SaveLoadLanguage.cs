using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class SaveLoadLanguage : MonoBehaviour
{
    public bool SLoad;
    public GameManager Manager;
    public bool lastLanguage;
    public int lastQuatly;

    bool seted = false;

    public void Start()
    {
            Load();
    }
    public void FixedUpdate()
    {
        if (!seted)
        {
            if (QualitySettings.GetQualityLevel() != lastQuatly)
            {
                QualitySettings.SetQualityLevel(lastQuatly);
                seted = true;
            }
        }
    }
    public void Save(bool Set, int Quality)
    {
        Debug.Log(Application.persistentDataPath);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/Mode.dat");
        WorldData data = new WorldData();
        data.Rus = Set;
        data.Quality = Quality;
        lastLanguage = Set;
        print("QUALITY: " + data.Quality);
        bf.Serialize(file, data);
        file.Close();
    }
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/Mode.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Mode.dat", FileMode.Open);
            WorldData data = (WorldData)bf.Deserialize(file);
            file.Close();
            lastLanguage = data.Rus;
            if (SLoad == true)
            {
                Manager.Rus = data.Rus;
            }
            lastQuatly = data.Quality;
            print("QUALITY: " + data.Quality);
            QualitySettings.SetQualityLevel(data.Quality);
        }

    }
    [Serializable]
    class WorldData
    {
        public int Quality;
        public bool Rus = false;
    }
}
