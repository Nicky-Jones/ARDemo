using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreenRemoval : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 reset = new Vector3(0,0,0);
    [SerializeField]
    private GameObject parent;
    void Start()
    {
        parent = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        parent.SetActive(false);
    }
}
