using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseResume : MonoBehaviour
{
    public static bool isPaused;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
public void PauseGame(){
isPaused = !isPaused;
 if(isPaused)
        {
            Time.timeScale = 0f;
        }
        else 
        {
            Time.timeScale = 1;
        }
}
   
}
