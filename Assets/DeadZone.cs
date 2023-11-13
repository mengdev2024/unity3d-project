using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
    private void OnTriggerExit(Collider collider)
    {
        collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    private void OnTriggerStay(Collider collider)
    {
        
    }
}
