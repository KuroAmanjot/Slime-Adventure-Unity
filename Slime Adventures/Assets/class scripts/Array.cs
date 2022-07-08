using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{

    public int[] score ; 
    // Start is called before the first frame update
    void Start()
    {
        //int new_score;
        int[] new_score = new int[5];
        new_score[0] = score[0] + score[1];
        // new_score = score[0] + score[1];
        //  Debug.Log( new_score );
        //new_score.Add
        Debug.Log(new_score[0]);
        //Debug.Log(new_score.Length);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
