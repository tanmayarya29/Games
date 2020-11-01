using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class randomMvt : MonoBehaviour {
     public float speed = 1;
     // Use this for initialization
     void Start () {
         GetComponent<Rigidbody2D> ();
 
     }
     
     void FixedUpdate(){
         Vector2 Movement = new Vector2 (Random.Range(-1, 1), Random.Range(-1, 1));
         GetComponent<Rigidbody2D>().AddForce(Movement);
   
     }
 }