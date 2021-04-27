using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Gameoverpanel;
    
    public void EndGame(){
        Debug.Log("Game Over");
        Gameoverpanel.SetActive(true);
    }
    public void StartLevel(){
        Debug.Log("Lets Go!"); 
    }
}
