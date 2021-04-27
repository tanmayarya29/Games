using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endtrgr : MonoBehaviour
{
    void OnTriggerEnter(Collider col) {
        if(col.name=="Player")
        SceneManager.LoadScene("terr");
    }
}
