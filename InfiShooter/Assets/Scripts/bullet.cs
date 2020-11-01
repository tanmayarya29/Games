using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject explodeEffect;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        GameObject effect = Instantiate(hitEffect,transform.position,Quaternion.identity);
        Destroy(effect,0.05f);
        if (collision.gameObject.name=="enemy(Clone)")
        {
            scoreInc.scoreVal+=1;
            Destroy(collision.gameObject);
            GameObject effect2 = Instantiate(explodeEffect,transform.position,Quaternion.identity);
            Destroy(effect2,1f);
        }
        Destroy(gameObject);
        
    }
}
