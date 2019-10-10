using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ThirdPersonCharacter;
    [SerializeField] private Material blue;
    [SerializeField] private Material green;
    [SerializeField] private Material yellow;

    void Start()
    {
        ThirdPersonCharacter = Instantiate(Resources.Load("ThirdPersonController", typeof(GameObject))) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// changes the colour of the character to blue
    /// </summary>
    public void btnBlue()
    {
        /// finds the material of the character and changes its colour
        ThirdPersonCharacter.transform.GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
        /// updates the blue material to the current blue on the character
        blue.color = Color.blue;
        /// calls the set Material function in changeColourManager script
        changeColourManager.setMaterial(blue);
    }
    /// <summary>
    /// changes the colour of the character to green
    /// </summary>
    public void btnGreen()
    {
        /// finds the material of the character and changes its colour
        ThirdPersonCharacter.transform.GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        /// updates the blue material to the current green on the character
        green.color = Color.green;
        /// calls the set Material function in changeColourManager script
        changeColourManager.setMaterial(green);
    }
    /// <summary>
    /// changes the colour of the character to yellow
    /// </summary>
    public void btnYellow()
    {
        /// finds the material of the character and changes its colour
        ThirdPersonCharacter.transform.GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
        /// updates the blue material to the current green on the character
        yellow.color = Color.yellow;
        /// calls the set Material function in changeColourManager script
        changeColourManager.setMaterial(yellow);
    }
}