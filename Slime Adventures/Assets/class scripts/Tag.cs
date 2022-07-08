using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : MonoBehaviour
{
     public int hitPoints = 100;
     public HealthSystem healthsystem; 

    // Start is called before the first frame update

    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         if (collision.gameObject.tag == "light")
         {
           hitPoints -= 5;
             print(hitPoints); 

         }
     }*/


    private void OnCollisionStay2D(Collision2D collision)
    {
            
        if (collision.gameObject.tag == "light")
        {
            healthsystem.DamageSystem(1);
           
           // hitPoints -= 1;
            //print(hitPoints + "in light ");

          /*  if (hitPoints == 0 )
            {
                Destroy(gameObject); 
            }*/
        }



    }
    
}
