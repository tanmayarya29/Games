using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNxtLvl : MonoBehaviour
{
    public void loadnl(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
