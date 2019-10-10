using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenu : MonoBehaviour
{
    GameObject mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// checks all the child objects of a gameobject and sets one active and deactives the rest
    /// </summary>
    /// <param name="menuValue"></param>
    public void changeMenu(int menuValue)
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            if (i == menuValue)
                transform.GetChild(i).gameObject.SetActive(true);
            else
                transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
