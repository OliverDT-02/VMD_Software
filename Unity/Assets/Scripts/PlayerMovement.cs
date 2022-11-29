using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    [Header("Movement")]
    public float MoveSpeed, Drag;
    public Transform orientation;

    float XInput, YInput, ZInput ;
    Vector3 MoveDirection;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        InputPlayer();
        rb.drag = Drag;
        SpeedControl();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void InputPlayer()
    {
        XInput = Input.GetAxisRaw("Horizontal");
        ZInput = Input.GetAxisRaw("Vertical");
        YInput = Input.GetAxisRaw("Volar");
    }
    private void MovePlayer()
    {
        MoveDirection = orientation.forward * ZInput + orientation.right * XInput + orientation.up * YInput;
        rb.AddForce(MoveDirection.normalized * MoveSpeed * 10f, ForceMode.Force);
    }
        

    private void SpeedControl()
    {
        Vector3 ActualVel = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z);

        if (ActualVel.magnitude > MoveSpeed)
        {
            Vector3 LimitVel = ActualVel.normalized * MoveSpeed;
            rb.velocity = new Vector3(LimitVel.x, LimitVel.y, LimitVel.z);
        }
    }
}