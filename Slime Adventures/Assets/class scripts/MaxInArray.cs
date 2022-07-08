using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arrayfunctions
{

public class MaxInArray : MonoBehaviour
{


   // private int[] number = { 5, 50, 30, 10, 5, 80,100 };
    
    void Start()
    {
       // print(MaxValueInArray(number));
        print(MaxValueInArray( new int[] {10,5,3,6,8,15,20 }));
        print(SmallValueInArray(new int[] { 10, 5, 3,1, 6, 8, 15 }));
        print(SumOfArray(new int[] { 1,2,5,7}));
    }


    void Update()
    {

    }

    public int MaxValueInArray(int[] array)
    {

        int greater = array[0]; 
        for (int i = 0; i < array.Length-1; i++)
        {
            if (greater < array[i + 1] )
            {

                greater = array[i + 1];
                
            }
        }
        return greater ;
    }

    public int SmallValueInArray(int[] array)
    {

        int smallest = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (smallest >= array[i])
            {

                smallest = array[i];

            }
        }
        return smallest;
    }

     public int SumOfArray(int[] array )
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i]; 
        }
        return sum; 
    }
}
}
