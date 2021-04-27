using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class strtgame : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("lvl1");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
