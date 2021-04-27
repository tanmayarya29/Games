using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayptController : MonoBehaviour
{
    private GameObject targetwp;

    public float mvSpeed= 10f;
    public float rtnSpeed= 3f;
    void Update()
    {
        targetwp = GameObject.FindGameObjectWithTag("Player");

        float mvStep=mvSpeed * Time.deltaTime;
        float rtnStep=rtnSpeed * Time.deltaTime;

        if(targetwp!=null){
            Vector3 dirn2tar=targetwp.transform.position-transform.position;
        Quaternion rotn2tar=Quaternion.LookRotation(dirn2tar);
        transform.rotation =  Quaternion.Slerp(transform.rotation,rotn2tar,rtnStep);
        float dist=Vector3.Distance(transform.position,targetwp.transform.position);
        // Debug.Log(dist);

        Debug.DrawRay(transform.position,transform.forward*50f,Color.green,0f);
        Debug.DrawRay(transform.position,dirn2tar,Color.red,0f);

        transform.position = Vector3.MoveTowards(transform.position,targetwp.transform.position-new Vector3(0,0,-5),mvStep);}
    }

}
