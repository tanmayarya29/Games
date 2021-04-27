using UnityEngine.Networking;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private Camera cam;
    public float damage=30;

    public Animator anim;
    //public targetEnemy targetEnemy;

    public ParticleSystem muzzleFlash;
    public GameObject impactFlash;
    public float impactForce = 30f;

    void Start()
    {
        if (cam == null)
        {
            Debug.Log("no cam referenced");
            this.enabled = false;
        }
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shooot();
        }
        if (Input.GetMouseButton(1)) 
        { 
            anim.SetTrigger("aim");
        }
        else
        {
            anim.SetTrigger("normal");
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

            targetEnemy te = hit.transform.GetComponent<targetEnemy>();
            if (te != null)
            {
                te.takeDmg(damage);
                hit.rigidbody.AddForce(-hit.normal* impactForce);
            }

            
            GameObject hef= Instantiate(impactFlash, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(hef, 2f);
        }
    }
}
