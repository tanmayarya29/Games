using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsGen : MonoBehaviour
{
    public Transform Obstacle;

    float timer;
    private void FixedUpdate()
    {

        timer += Time.deltaTime;
        if (timer > 10)
        {
            Oj();
            timer = 0;
        }
    }
    public void Oj(){
        Instantiate(Obstacle,gameObject.transform.position,Quaternion.identity);
    }
 }

    

