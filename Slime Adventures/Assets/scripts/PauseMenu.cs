using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public static bool gameIsPause = false ;
    public GameObject retryMenu; 
    public GameObject pauseMenuUI ;
    public GameObject thankyouMenu;
    //public isAliveHealth playerHealth;
    
    void Update()
    {

        if (!HealthSystem.isAlive)
        {
            retryMenu.SetActive(true);
            Time.timeScale = 0f;
            gameIsPause = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (gameIsPause)
            {
                Resume();

            }
            else
            {
                Pause(); 

            }
        }
        
    }

        public void Pause()
     {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPause = true; 

     }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
    }

    public void Exit()
    {
        Application.Quit();
        print("Quit"); 
    }

    public void MainMenu()
    {
        SceneManager.LoadScene( 0 );
        gameIsPause = false;
        Time.timeScale = 1f;
      
    }

    public void RetryLevel()
    {
        HealthSystem.isAlive = true;
        retryMenu.SetActive(false);
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameIsPause = false;
        Time.timeScale = 1f;
        print("retry working ");
        thankyouMenu.SetActive(false); 
    }

    
    


}
