using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    print("Space Button Pressed first time");
        //    GetComponent<Renderer>().material.color = Color.green;
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    print("Space Button Released");
        //    GetComponent<Renderer>().material.color = Color.yellow;
        //}
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    print("Space Button Held Down");

        //}
        //if (Input.GetButtonDown("Jump"))
        //{
        //    print("Space Button Pressed first time");
        //    GetComponent<Renderer>().material.color = Color.green;
        //}

        float xInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //print("x = " + xInput);
        //print("y = " + yInput);

        //Input.GetAxisRaw();

        transform.Translate(xInput, yInput, 0);

        print("deltaTime = "+Time.deltaTime);

        
    }
}
