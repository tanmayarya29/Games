using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controler;
    public float speed = 10;
    public float gravity = -9.8f;
    public float jumpHeight = 3f; //-root2gh

    public Transform groundChk;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundChk.position, groundDistance, groundMask);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        if (isGrounded && velocity.y<0)
        {
            velocity.y = -2f;

        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controler.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controler.Move(velocity * Time.deltaTime);
        

    }
}
