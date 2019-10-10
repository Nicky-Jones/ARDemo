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
    public void btnBlue()
    {
        ThirdPersonCharacter.transform.GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
        blue.color = Color.blue;
        changeColourManager.setMaterial(blue);
        Debug.Log("inside this function");
    }
    public void btnGreen()
    {
        ThirdPersonCharacter.transform.GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        green.color = Color.green;
        changeColourManager.setMaterial(green);
        Debug.Log("inside this function");
    }
    public void btnYellow()
    {
        ThirdPersonCharacter.transform.GetChild(0).GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
        yellow.color = Color.yellow;
        changeColourManager.setMaterial(yellow);
        Debug.Log("inside this function");
    }
}