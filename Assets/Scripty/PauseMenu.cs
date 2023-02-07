using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject canvasObj;
    bool gamePaused;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 0f;
            gamePaused = !gamePaused;
            

        }
        
            
        
        if (gamePaused)
        {
            canvasObj.SetActive(true);
        }
        else
        {
            canvasObj.SetActive(false);
            Time.timeScale = 1f;
        } 
           
       
        
        
            
        
     }
}
