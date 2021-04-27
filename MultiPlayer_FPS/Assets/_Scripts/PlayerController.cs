using UnityEngine;
[RequireComponent(typeof(ConfigurableJoint))]
[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]//use for showing private in inspector
    private float speed = 5f;
    [SerializeField]
    private float mSen = 3f;

    [SerializeField]
    private float thrustForce = 1000f;

    [Header("Spring settings:")]
    [SerializeField]
    private float jointSpring=20f;
    [SerializeField]
    private float jointMaxForce = 40f;



    private PlayerMotor motor;
    private ConfigurableJoint cj;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
        cj = GetComponent<ConfigurableJoint>();
        setJoinSetting(jointSpring);
    }

    void Update()
    {
        //Calculate mvt vel as 3d vector
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 moveH = (transform.right * xMove );//(1,0,0)
        Vector3 moveV = (transform.forward * zMove);//(0,0,1)

        //final mvmt vector
        Vector3 _velocity = (moveH + moveV).normalized * speed;

        //apply mvt
        motor.move(_velocity);

        //calc rotn as 3d vector(turn around)
        float yrot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotn = new Vector3(0f, yrot, 0f) * mSen;

        //apply rotn
        motor.rotate(_rotn);

        //calc rotn as 3d vector(turn around)
        float xrot = Input.GetAxisRaw("Mouse Y");

        float _camRotn = xrot * mSen;

        //apply camera rotn(up down)
        motor.camRotate(_camRotn);


        //calc tf based on space key
        Vector3 _thrusterFOrce = Vector3.zero;
        if (Input.GetButton("Jump"))
        {
            _thrusterFOrce = Vector3.up * thrustForce;
            setJoinSetting(0f);
        }
        else
        {
            setJoinSetting(jointSpring);
        }


        //apply thruster force
        motor.applyThrusterForce(_thrusterFOrce);
    }

    private void setJoinSetting(float _jointSpring)
    {
        cj.yDrive = new JointDrive {
            positionSpring = _jointSpring,
            maximumForce = jointMaxForce
        };
    }
}
