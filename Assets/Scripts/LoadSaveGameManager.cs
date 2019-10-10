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

    public void loadSaveGame()
    {
        dController.loadGameData();
    }
    public void deleteSaveGame()
    {
        dController.deleteSaveGameData();
    }
}
