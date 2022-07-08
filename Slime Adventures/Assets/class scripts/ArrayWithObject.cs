using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayWithObject : MonoBehaviour
{

    public GameObject[] objects ;
    public Color[] solidcolor;
    //private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        //rend = GetComponent<Renderer>();
        // objects.renderer.materials[2].color = solidcolor[1];
        objects[1].GetComponent<SpriteRenderer>().color =  solidcolor[2]; //solidcolor[2]; 



    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
