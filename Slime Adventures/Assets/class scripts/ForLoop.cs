using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    public int n;
    
    // Start is called before the first frame update
    void Start()
    {
        print("running loop ......");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {

              Debug.Log(" *" );
                
            }
            Debug.Log("\n");

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
