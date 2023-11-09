using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    public int power = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (power)
        {
            case 0:
                print("You are beginner player");
                break;
            case 1:
                print("You are intermediate player");
                break;
            case 2:
                print("You are an advanced player");
                break;
            default:
                print("You are not a player");
                break;
        }
    }
}
