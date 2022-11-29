using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float sensX, sensY;
    public Transform orientation;
    float rotationX, rotationY;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //mouse input
        if (!Menus.Paused)
        {
            float mouseX = Input.GetAxisRaw("Mouse X") * sensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * sensY;

            rotationX -= mouseY;
            rotationY += mouseX;

            rotationX = Mathf.Clamp(rotationX, -90, 90);

            //rotation and orientation



            transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
            orientation.rotation = Quaternion.Euler(0, rotationY, 0);
        }
           
        
        
    }
}
