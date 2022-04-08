using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float Speed = 10f;
    private float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        float horizontalmovement = Input.GetAxis("Horizontal");
        float verticalmovement = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalmovement, 0, verticalmovement);
        movementDirection.Normalize();

        if(movementDirection != Vector3.zero)
        {
            transform.forward = movementDirection;
        }

        transform.Translate(movementDirection * rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) && !Input.GetMouseButton(0)) 
        {
            transform.Translate(0f, 0f, Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.S) && !Input.GetMouseButton(0))
        {
            transform.Translate(0f, 0f, Time.deltaTime * -Speed);
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetMouseButton(0))
        {
            transform.Translate(Time.deltaTime * -Speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D) && !Input.GetMouseButton(0))
        {
            transform.Translate(Time.deltaTime * Speed, 0f, 0f);
        }
    }
}
