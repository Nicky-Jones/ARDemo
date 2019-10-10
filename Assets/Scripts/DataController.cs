using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Json;
using System.Linq;
using UnityEditor;

public class DataController : MonoBehaviour
{
    public static DataController dataController;
    public bool trigger1Reached;
    public bool trigger2Reached;
    string filePath;
    private string gameDataFileName = "data.json";
    GameData saveData;

    private void Start()
    {
        if (dataController == null)
        {
            dataController = this;
        }
        else if (dataController != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);
    }
    /// <summary>
    /// updates the variables in the save data with the current variables and saves the information to a json data file
    /// </summary>
    public void saveGameData()
    {
        saveData = new GameData();
        saveData.name = "TriggeredData";
        saveData.trigger1Reached = trigger1Reached;
        saveData.trigger2Reached = trigger2Reached;
        string jsonData = JsonUtility.ToJson(saveData, true);
        File.WriteAllText(filePath, jsonData);
        Debug.Log("Saving as Json: " + filePath);
    }
    /// <summary>
    /// function to load the game data from the Json file
    /// </summary>
    public void loadGameData()
    {

        if(File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);

            GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);

            trigger1Reached = loadedData.trigger1Reached;
            trigger2Reached = loadedData.trigger2Reached;
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        else
        {
            Debug.LogError("Cannot load game data");
        }
    }
    /// <summary>
    /// function to delete the save data file and reset the current variables to default
    /// </summary>
    public void deleteSaveGameData()
    {
        string saveGameFile = Application.dataPath + "/StreamingAssets/data.json";
        File.Delete(saveGameFile);
        trigger1Reached = false;
        trigger2Reached = false;
    }
}
