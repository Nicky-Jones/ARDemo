using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColourManager : MonoBehaviour
{
    static GameObject ThirdPersonCharacter;

    static changeColourManager()
    {
        ThirdPersonCharacter = Resources.Load("ThirdPersonController") as GameObject;
    }

    public static GameObject getCharacter()
    {
        return ThirdPersonCharacter;
    }

    static public void setCharacter(GameObject newCharacter)
    {
        ThirdPersonCharacter = newCharacter;
    }
    static public void setMaterial(Material mat)
    {
        ThirdPersonCharacter.transform.GetChild(0).GetComponent<Renderer>().material = mat;
    }
}
