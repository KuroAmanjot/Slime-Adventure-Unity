using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int[] numbers = {1,2,3,4,5,6,7,8,9,10};
        int evencount = 0;
        int oddcount = 0;
        int zerocount = 0;
        foreach (int i in numbers)
        {

            if (i%2 == 0)
            {
                evencount += 1;
            }
            else if (i%2 != 0)
            {
                oddcount += 1;
            }
            else
            {
                zerocount += 1; 
            }
            

        }

        Debug.Log("even " + evencount);
        Debug.Log("odd " + oddcount);
        Debug.Log("zero " + zerocount);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
