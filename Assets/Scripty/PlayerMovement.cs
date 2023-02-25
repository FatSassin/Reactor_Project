using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 10f;
    public float gravityForce = -9.81f;

    public float normalHeight, crouchHeight;

    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            controller.height = crouchHeight;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            controller.height = normalHeight;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravityForce * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
