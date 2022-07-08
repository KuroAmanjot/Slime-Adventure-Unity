using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberTogether : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print (Two7sNextToEachOther(new int[] { 1,8,56,8,6,9,7,7,1,5,7,7,2,5,}));
        print(Two7sNextToEachOther(new int[] { 1, 8, 56, 8, 6, 9, 7, 7, 1, 5, 7, 7, 2, 5, 7, 7 }));
    }

    // Update is called once per frame
    public int Two7sNextToEachOther(int[] array ) 
    {
        int count = 0;
        for (int i = 0; i < array.Length-1; i++)
        {

            if (array[i] == 7 && array[i+1] == 7 )
            {
                count += 1; 
            }

        }
        return count ; 
    }
}
