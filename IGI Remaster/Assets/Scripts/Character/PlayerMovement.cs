using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Faizan.Game.Systems;

internal class PlayerMovement : MovementSystem
{
    private Rigidbody rigidbody;
    private const float jumpForce=1000;
    private float rotationValue;


    private void Awake()
    {
        if (characterType == CharacterType.Player)
            rigidbody = GetComponent<Rigidbody>();

    }



    private void Update()
    {
        MovementMechanics();
    }
    private void FixedUpdate()
    {
        Movement();
    }

    private void MovementMechanics()
    {

      
        Rotation();
        if (Input.GetKeyDown(KeyCode.V) /*&& IsGrounded()*/)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }



    private void Movement()
    {

        float X = Mathf.Clamp(Input.GetAxis(GameConstants.Keyboard_Horizontal) * 100000, -1, 1);
        float Y = Mathf.Clamp(Input.GetAxis(GameConstants.Keyboard_Vertical) * 1000000, -1, 1);


        Vector3 direction = transform.right * X + transform.forward * Y;
        Vector3 newPosition = rigidbody.position + direction * GameConstants.PlayerMovementSpeed * Time.fixedDeltaTime;
        rigidbody.MovePosition(newPosition);
        //transform.localPosition += direction; 


        //rigidbody.velocity = direction * GameConstants.PlayerMovementSpeed;

        //if (X == 0 && Y == 0)
        //{
        //    rigidbody.velocity = Vector3.zero;
        //}
    }
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f);
    }
    private void Rotation()
    {

        if (!Input.GetMouseButton(0))
            return;

        rotationValue += Input.GetAxis(GameConstants.Mouse_Horizontal);


        transform.rotation = Quaternion.Euler(Vector3.up * rotationValue);


    }


   


}
