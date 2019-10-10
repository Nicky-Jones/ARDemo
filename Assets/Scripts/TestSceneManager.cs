using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSceneManager : MonoBehaviour
{
    [SerializeField]
    GameObject tick1;
    [SerializeField]
    GameObject tick2;
    [SerializeField]
    GameObject trigger1UI;
    [SerializeField]
    GameObject trigger2UI;
    [SerializeField]
    GameObject congratulationScene;
    DataController dController;
    // Start is called before the first frame update
    void Start()
    {
        dController = GameObject.Find("SaveManager").GetComponent<DataController>();
        updateTriggers(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void updateTriggers(int triggerNumber)
    {
        if(triggerNumber == 0)
        {
            if (dController.trigger1Reached == true)
                tick1.SetActive(true);
            if (dController.trigger2Reached == true)
                tick2.SetActive(true);
        }
        if (triggerNumber == 1)
            if (tick1.activeInHierarchy == true)
                return;
            else
                updateTick1();
        else if (triggerNumber == 2)
            if (tick2.activeInHierarchy == true)
                return;
            else
                updateTick2();
        else
            Debug.Log("Error: invalid trigger number");
        if (tick1.activeInHierarchy == true && tick2.activeInHierarchy == true)
            StartCoroutine(congratulationScenePopUP(2, congratulationScene));
            
    }

    private void updateTick1()
    {
        tick1.SetActive(true);
        dController.trigger1Reached = true;
        dController.saveGameData();
        StartCoroutine(UIPopUP(2, trigger1UI));
    }
    private void updateTick2()
    {
        tick2.SetActive(true);
        dController.trigger2Reached = true;
        dController.saveGameData();
        StartCoroutine(UIPopUP(2, trigger2UI));
    }
    private IEnumerator UIPopUP(float delay, GameObject UI)
    {
        UI.SetActive(true);
        yield return new WaitForSeconds(delay);
        UI.SetActive(false);
    }
    private IEnumerator congratulationScenePopUP(float delay, GameObject UI)
    {
        yield return new WaitForSeconds(delay);
        UI.SetActive(true);
    }
}
