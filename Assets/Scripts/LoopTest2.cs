using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest2 : MonoBehaviour
{

    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
