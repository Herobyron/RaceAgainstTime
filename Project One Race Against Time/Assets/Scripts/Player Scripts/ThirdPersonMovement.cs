using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController Controller;

    public Transform Camera;

    public float speed = 6.0f;

    public float JumpHieght = 3.0f;

    public float TurnSmoothTime = 0.1f;

    private float TurnSmoothVelocity;

    // the movement infomration in accordance to the axis
    private float Horizontal = 0.0f;
    private float Vertical = 0.0f;

    // a vector three that is the direction of the player
    Vector3 Direction;


    Vector3 CurrentVelocity;
    public float gravity = -9.81f;


    public Transform GroundCheck;
    public float GroundDistance = 0.4f;
    public LayerMask GroundMask;

    private bool IsGrounded;

    // Update is called once per frame
    void Update()
    {
        IsGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);

        if(IsGrounded && CurrentVelocity.y < 0)
        {
            CurrentVelocity.y = -2f;
        }

        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
        Direction = new Vector3(Horizontal, 0f, Vertical).normalized;

        if(Direction.magnitude >= 0.01f)
        {
            float TargetAngle = Mathf.Atan2(Direction.x, Direction.z) * Mathf.Rad2Deg + Camera.eulerAngles.y;

            float Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, TargetAngle, ref TurnSmoothVelocity, TurnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, Angle, 0f);

            Vector3 MoveDirection = Quaternion.Euler(0f, TargetAngle, 0f) * Vector3.forward;
            Controller.Move(MoveDirection.normalized * speed * Time.deltaTime);
        }

        if(Input.GetButtonDown("Jump") && IsGrounded)
        {
            CurrentVelocity.y = Mathf.Sqrt(JumpHieght * -2f * gravity);
        }


        CurrentVelocity.y += gravity * Time.deltaTime;

        Controller.Move(CurrentVelocity * Time.deltaTime);

    }
}
