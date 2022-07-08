using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayQuestion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       print(ThreeIncreasingAdjacent(new int[] { 1,5,3,5,8,6,} ));
        print(ThreeIncreasingAdjacent(new int[] { 1, 5, 3, 4, 5, 6, 9}));


    }

    public bool ThreeIncreasingAdjacent ( int[] array )
    {
        bool check= false ;
        for (int i = 1; i < array.Length - 1 ; i++)
        {
            if (array[i - 1] + 1 == array[i]  && array[i + 1] - 1 == array[i])
            {

                check = true;

            }

        }
        return check ; 
        
    }
}
