using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{

    // Update is called once per frame

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            end();
        }
    }

    public void end()
    {
        Cursor.lockState = CursorLockMode.None;

        SceneManager.LoadScene("End");
    }

    public void Quit()
    {

            Application.Quit();
        
    }
}
