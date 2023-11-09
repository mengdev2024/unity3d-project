using UnityEngine;


public class FirstScript : MonoBehaviour 
{

    public bool killPlayer;

    // Start is called before the first frame update
    void Start()
    {

    }   

    // Update is called once per frame
    void Update()
    {
        if (killPlayer)
        {
            Destroy(gameObject,2f);
        }
       
    }

}
