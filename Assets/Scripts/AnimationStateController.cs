using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("IsRunning", true);
        }

        if (!Input.GetKey("w"))
        {
            animator.SetBool("IsRunning", false);
        }

        if(Input.GetMouseButton(0))
        {
            animator.SetBool("IsAttacking", true);
        }

        if (!Input.GetMouseButton(0))
        {
            animator.SetBool("IsAttacking", false);
        }

        if (Input.GetKey("e"))
        {
            animator.SetBool("FinisherTime", true);
        }

        if (!Input.GetKey("e"))
        {
            animator.SetBool("FinisherTime", false);
        }
    }
}
