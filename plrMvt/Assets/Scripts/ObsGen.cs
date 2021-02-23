using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsGen : MonoBehaviour
{
    public Transform obj;
    public Transform Obstacle;
    public float z;
    public float randomX;
    public float factor;

    // Start is called before the first frame update
    void Start()
    {
        z=50;
    }

//     private float time = 0.0f;
//  public float interpolationPeriod = 0.05f;
 
 void FixedUpdate () {
    //  time += Time.deltaTime;
    //  if (time >= interpolationPeriod) {
    //      time = 0.0f;
 
         // execute block of code here
         if(Mathf.Floor(obj.position.z)%factor==0){
         Oj();
         }
     }

     void Oj(){
        randomX=Random.Range(-3.5F,3.5F);
        Instantiate(Obstacle,new Vector3(randomX,1F,z+=20),Quaternion.identity);
    }
 }

    

