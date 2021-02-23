using UnityEngine.Networking;
using UnityEngine;

public class PlayerShoot : NetworkBehaviour
{
    public PlayerWeapon weapon;
    [SerializeField]
    private Camera cam;

    public Animator anim;
    //public targetEnemy targetEnemy;

    [SerializeField]
    private LayerMask mask;

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
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, weapon.range, mask))
        {
            //we hit
            Debug.Log(hit.collider.tag);

            targetEnemy te = hit.transform.GetComponent<targetEnemy>();
            if (te != null)
            {
                te.takeDmg(PlayerWeapon.damage);
                hit.rigidbody.AddForce(-hit.normal* impactForce);
            }

            
            GameObject hef= Instantiate(impactFlash, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(hef, 2f);
        }
    }
}
