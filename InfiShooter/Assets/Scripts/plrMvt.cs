using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plrMvt : MonoBehaviour
{
    public float mvspd=5f;

    public static bool Tover=false;
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 mvt;
    Vector2 msposn;

    // Update is called once per frame
    void Update()
    {
        mvt.x=Input.GetAxisRaw("Horizontal");
        mvt.y=Input.GetAxisRaw("Vertical");
        msposn=cam.ScreenToWorldPoint(Input.mousePosition);
        
    }
    void FixedUpdate()
    {
        if (Tover==false)
        {
            rb.MovePosition(rb.position+mvt*mvspd*Time.fixedDeltaTime);
            Vector2 lookDir=msposn-rb.position;
            float angle=Mathf.Atan2(lookDir.y,lookDir.x)*Mathf.Rad2Deg;
            rb.rotation=angle;
        }
       
    }
}
