using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createEnemy : MonoBehaviour
{
    public GameObject enemy_prefab;
    void Start(){
        GameObject.Instantiate(enemy_prefab,transform.position,Quaternion.identity);
       
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
        Vector2 posn=new Vector2(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        GameObject.Instantiate(enemy_prefab,posn,Quaternion.identity);
        
        }
    }
}
