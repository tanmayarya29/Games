using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    [SerializeField]
    private Camera cam;


    private Vector3 velocity=Vector3.zero;
    private Vector3 rotation=Vector3.zero;
    private float camrotation=0f;
    private float currentCamrotation=0f;
    private Vector3 tf=Vector3.zero;

    [SerializeField]
    private float camRotnLim = 85f;


    private Rigidbody rb;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }

    //gets the mvt vector
    public void move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    //gets the cam rotn vector
    public void rotate(Vector3 _rotn)
    {
        rotation = _rotn;

    }

    //gets the rotn vector
    public void camRotate(float _rotn)
    {
        camrotation = _rotn;

    }

    //gets the thrusting vector
    public void applyThrusterForce(Vector3 _thrusterForce)
    {
        tf = _thrusterForce;
    }

    //runs iteration per sec
    void FixedUpdate()
    {
        PerformMvt();
        PerformRotn();
    }

    //perform mvt
    void PerformMvt()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position+velocity*Time.fixedDeltaTime);
        }
        if (tf != Vector3.zero)
        {
            rb.AddForce(tf * Time.fixedDeltaTime,ForceMode.Acceleration);
        }
    }

    //perform rotn
    void PerformRotn()
    {
        
            rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
         if (cam!=null)
        {
            //cam.transform.Rotate(-camrotation);
            //set rotn n lamp it
            currentCamrotation -= camrotation;
            currentCamrotation = Mathf.Clamp(currentCamrotation, -camRotnLim, camRotnLim);
            //apply rotn to transform
            cam.transform.localEulerAngles = new Vector3(currentCamrotation, 0f, 0f);


        }
     
    }


}
