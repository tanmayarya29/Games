using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Camera cam;
    public float gvDmg=5f;
    public float interval=2f;

    //public TargetPlayer TargetPlayer;

    public ParticleSystem muzzleFlash;
    public GameObject impactFlash;
    public float impactForce = 30f;
    float timer;
    void FixedUpdate()
    {
         timer += Time.deltaTime;
         if(timer>interval)
        {
            shooot();
            timer = 0;
        }
    }

    void shooot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            //we hit
            Debug.Log(hit.collider.tag);
            try{
            TargetPlayer tp = hit.transform.GetComponent<TargetPlayer>();
            if (tp != null)
            {
                tp.takeDmg(gvDmg);
                hit.rigidbody.AddForce(-hit.normal* impactForce);
            }
            }
            catch{
                return;
            }

            GameObject hef= Instantiate(impactFlash, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(hef, 2f);
        }
    }
    
}
