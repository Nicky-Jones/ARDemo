using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveGameManager : MonoBehaviour
{
    private DataController dController;
    // Start is called before the first frame update
    void Start()
    {
        dController = GameObject.Find("SaveManager").GetComponent<DataController>();
    }

    /// <summary>
    /// calls the load game data function from DataController
    /// </summary>
    public void loadSaveGame()
    {
        dController.loadGameData();
    }

    /// <summary>
    /// calls the delete save game data function from DataController
    /// </summary>
    public void deleteSaveGame()
    {
        dController.deleteSaveGameData();
    }
}
