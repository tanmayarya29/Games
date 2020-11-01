using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firept; 
    public GameObject bulletPrefab;
    public float bf=20f;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1") && plrMvt.Tover==false)
        {
            shoot();
        }
    }

    void shoot()
    {
        GameObject bullet=Instantiate(bulletPrefab,firept.position,firept.rotation);
        Rigidbody2D rb=bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firept.up*bf,ForceMode2D.Impulse);
    }
}
