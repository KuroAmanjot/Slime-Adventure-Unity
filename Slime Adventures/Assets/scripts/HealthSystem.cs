using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class HealthSystem : MonoBehaviour
{

    //public Image heartUI;
    public Sprite deadHeartSprite;
    public Sprite aliveHeartSprite;
    public Image[] hearts;
    public int lifelines;
    public int heartContainer;    
    public static bool isAlive ; 
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        print("alive"); 
    }
        

        // Update is called once per frame
        void Update()
          {

            if (lifelines > heartContainer )
            {
                lifelines = heartContainer;
            }

            for (int i = 0; i < hearts.Length; i++)
            {
                if (i< lifelines)
                {
                    hearts[i].sprite = aliveHeartSprite;
                }
                else
                {
                    hearts[i].sprite = deadHeartSprite; 
                }
                if (i< heartContainer )
                {
                    hearts[i].enabled = true;

                }
                else
                {
                    hearts[i].enabled = false;
                }




            }


        if (isAlive == false )
        {
                // dead script 
            
            Destroy(gameObject); 
            print("Player died"); 
        }
        
    }

    public  void  DamageSystem(int dmg)
    {
        lifelines -= dmg;
        //Destroy(hearts[lifelines].gameObject);
            
        
        if (lifelines < 1)
        {
            isAlive = false; 

        }
    }
}

