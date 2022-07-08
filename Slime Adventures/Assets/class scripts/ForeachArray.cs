using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachArray : MonoBehaviour


{

    public GameObject[] Obj = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject i in Obj)
        {
            Destroy(i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
