using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintCubes : MonoBehaviour
{

    public int[] digits = { 1,2,3,4,5}; 
    // Start is called before the first frame update
    void Start()
    {

        /*int[] calcubes = new int[digits.Length];
        int cube;
        for (int i = 0; i < digits.Length; i++)
        {
            cube = digits[i] * digits[i] * digit[i];
            calcubes[i] = cube;
        }*/

        int[] ans = FindingCubes(digits); 

        foreach (int i in ans)
        {
            Debug.Log(i);
        }
    }

    public int[] FindingCubes(int[] numbers)
    {
        int[] calcubes = new int[numbers.Length]; 
        int cube;
        for (int i = 0; i < numbers.Length ; i++)
        {
            cube = numbers[i] * numbers[i] * numbers[i];
            calcubes[i] = cube; 
        }
                    
        /*foreach (int i in numbers)
        {
            cube = i * i * i;
            calcubes[] = cube; 
       

        }*/

        return calcubes ; 
    }
}
