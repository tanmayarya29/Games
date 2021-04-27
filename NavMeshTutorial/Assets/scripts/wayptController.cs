using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayptController : MonoBehaviour
{
    public List<Transform> wp=new List<Transform> ();
    private Transform targetwp;
    private int targetWpIndex=0;
    private float minDist=0.1f;
    private int lastWpIndex;

    public float mvSpeed= 10f;
    public float rtnSpeed= 3f;
    // Start is called before the first frame update
    void Start()
    {
        lastWpIndex=wp.Count-1;
        targetwp=wp[targetWpIndex];
        
    }

    // Update is called once per frame
    void Update()
    {

        

        float mvStep=mvSpeed * Time.deltaTime;
        float rtnStep=rtnSpeed * Time.deltaTime;

        Vector3 dirn2tar=targetwp.position-transform.position;
        Quaternion rotn2tar=Quaternion.LookRotation(dirn2tar);
        transform.rotation =  Quaternion.Slerp(transform.rotation,rotn2tar,rtnStep);
        float dist=Vector3.Distance(transform.position,targetwp.position);
        // Debug.Log(dist);

        Debug.DrawRay(transform.position,transform.forward*50f,Color.green,0f);
        Debug.DrawRay(transform.position,dirn2tar,Color.red,0f);

        chkDist2wp(dist);
        transform.position = Vector3.MoveTowards(transform.position,targetwp.position,mvStep);
    }

    void chkDist2wp(float currDist){
        if(currDist<minDist)
       { targetWpIndex++;
        UpdateTargetwp();}
    }
    void UpdateTargetwp(){
        if(targetWpIndex>lastWpIndex){
            targetWpIndex=0;
        }
        targetwp=wp [targetWpIndex];
    }
}
