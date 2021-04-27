using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endtrgr2 : MonoBehaviour
{
    void OnTriggerEnter(Collider coll){
        if(coll.name=="Player"){
        Cursor.lockState=CursorLockMode.None;
        SceneManager.LoadScene("End");}
    }
}
