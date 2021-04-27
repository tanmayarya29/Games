using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float mouseZ,mouseY;
    public float mouse_sensi=1f;
    public Transform Player;

    float xRotn = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //time.deltatime for syncing frame and movement script

        mouseZ = Input.GetAxis("Mouse Y") * mouse_sensi * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse X") * mouse_sensi * Time.deltaTime;

        xRotn -= mouseZ;
        xRotn = Mathf.Clamp(xRotn, -80, 80);
        transform.localRotation = Quaternion.Euler(xRotn, 0, 0);

        //Player.Rotate(new Vector3(-mouseZ, mouseY, 0));
        Player.Rotate(Vector3.up * mouseY);
    }
}
