using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class ObstaclesAndButtons : MonoBehaviour
{
    // Start is called before the first frame update
    


     
      void Update() 
     {

         ReloadLevelCheat();
         

     }


         
        

            void OnCollisionEnter(Collision other) 
       {
           if (other.gameObject.tag == "Obstacle") 
            {
              ReloadLevel();
            } 

            else if (other.gameObject.tag == "Button")
            {
                LoadNextLevel();
            }
            
            else if (other.gameObject.tag == "LoadTheBaseScene") 
            {
                LoadBaseScene();
            }

            else if (other.gameObject.tag == "NextLevelGate") 
            {
                LoadNextLevel();
            }

            else if (other.gameObject.tag == "LoadBaseScene2") 
            {
                LoadBaseScene2();
            }
            
            else if (other.gameObject.tag == "LoadBaseScene3") 
            {
                LoadBaseScene3();
            }

            else if (other.gameObject.tag == "QuitGame") 
            {
                QuitTheGame();
            }
       

        }
    

  
  

    
    
    void ReloadLevel() 
    {   
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene);
    }
    
    void LoadNextLevel()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene + 1);
    }

    void LoadBaseScene()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Level 1");
    }

    void LoadBaseScene2() 
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Level 2");
    }

    void LoadBaseScene3()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Last Level (Part 1)");
    }



     void ReloadLevelCheat() 
     {
         if(Input.GetKey(KeyCode.R)) 
      {
         ReloadLevel();
      }
     }
    
    void QuitTheGame() 
    {
        Application.Quit();
    }
    
}
