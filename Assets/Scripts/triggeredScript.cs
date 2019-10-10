using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggeredScript : MonoBehaviour
{
    TestSceneManager tSM;
    [SerializeField] int triggerNumber;
    // Start is called before the first frame update
    void Start()
    {
        tSM = GameObject.Find("SceneManager").GetComponent<TestSceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        tSM.updateTriggers(triggerNumber);
    }
}
