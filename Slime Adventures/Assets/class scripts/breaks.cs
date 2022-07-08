using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Arrayfunctions; 

public class breaks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 0; 
        while (x<5)
        {
            if (x==2)
            {
                continue; 
            }
            print("*");
            x++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
