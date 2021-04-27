using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private TargetPlayer tp;
    
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name=="Player")
        {
            tp=collision.gameObject.GetComponent<TargetPlayer>();
            tp.takeDmg(30f);
        }
        Destroy(gameObject);
    }
}
