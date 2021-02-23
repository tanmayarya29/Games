using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlrMvt movement;
    // public GameManager gameManager;
    public ObsGen obsgen;
    
    void OnCollisionEnter(Collision col){
        // Debug.Log(col.collider.name);
        // if(col.collider.name=="Obstacle"){
        //     Debug.Log(col.gameObject.);
        //     Debug.Log("i hit somethin...");

        // }
        if(col.collider.tag=="Obstacle"){
            FindObjectOfType<GameManager>().EndGame();

            var rndr=col.gameObject.GetComponent<Renderer>();
            rndr.material.SetColor("_Color",Color.red);
            // Destroy(col.gameObject);
            // Debug.Log("i hit somethin...");
            movement.enabled=false;
            obsgen.enabled=false;
        }
    }
}
