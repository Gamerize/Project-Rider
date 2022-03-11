using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float Speed = 10f;

    // Update is called once per frame
    void Update()
    {
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
