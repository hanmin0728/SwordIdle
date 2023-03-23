using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoSingleTon<GameManager>
{
    public UserInfo userInfo;

    private string SAVE_PATH = "";
    private string SAVE_FILENAME = "/UserInfoSaveFile.txt";

    void Awake()
    {
        SAVE_PATH = Application.dataPath + "/Save"; // persistentDataPath
        if (Directory.Exists(SAVE_PATH) == false)
        {
            Directory.CreateDirectory(SAVE_PATH);
        }
        LoadFromJson();
        InvokeRepeating("SaveToJson", 1f, 3f);
    }
    private void LoadFromJson()
    {
        string json = "";
        if (File.Exists(SAVE_PATH + SAVE_FILENAME) == true)
        {
            json = File.ReadAllText(SAVE_PATH + SAVE_FILENAME);
            userInfo = JsonUtility.FromJson<UserInfo>(json);
        }
    }

    public void SaveToJson()
    {
        Debug.Log("ภ๚ภๅตส");
        SAVE_PATH = Application.dataPath + "/Save"; // persistentDataPath
        string json = JsonUtility.ToJson(userInfo, true);
        File.WriteAllText(SAVE_PATH + SAVE_FILENAME, json, System.Text.Encoding.UTF8);
    }


    void Update()
    {
    }
}
