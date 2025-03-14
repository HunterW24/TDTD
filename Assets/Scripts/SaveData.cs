using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using System.IO;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    public int playerHealth;
    public int score;


    public void SaveGame()
    {
        SaveData data = new SaveData();
        // Populate the data with current game state
        data.playerHealth = playerHealth;
        data.score = score;

        string jsonData = JsonUtility.ToJson(data);

        // Specify the file path (adjust as needed)
        string filePath = Application.persistentDataPath + "/saveData.json";

        File.WriteAllText(filePath, jsonData);
    }

    public void LoadGame()
    {
        string filePath = Application.persistentDataPath + "/saveData.json";

        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            SaveData data = JsonUtility.FromJson<SaveData>(jsonData);

            // Load the data into the game state
            playerHealth = data.playerHealth;
            score = data.score;
        }
    }

    public void SaveAndQuit()
    {
        SaveGame();
        Application.Quit();
    }
}
