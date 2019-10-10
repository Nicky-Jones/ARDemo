using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneByIndex : MonoBehaviour
{
    /// <summary>
    /// changes the scene using the parameter sceneIndex
    /// </summary>
    /// <param name="sceneIndex"></param>
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }
}
