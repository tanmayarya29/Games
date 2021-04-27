using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlrMvt : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("up"))
        {
            rb.AddForce(0,0,sidewaysForce * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            rb.AddForce(0,0,-sidewaysForce * Time.deltaTime);
        }

        if(rb.position.y<-1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
