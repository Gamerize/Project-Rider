using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private InputActionReference movementControl;

    int isRunningHash;
    int isChangingHash;

    PlayerController controller;

    Vector2 currentMovement;
    bool movementPressed;

    private void Awake()
    {
        controller = new PlayerController();

        movementControl.action.performed += ctx =>
        {
            currentMovement = ctx.ReadValue<Vector2>();
            movementPressed = currentMovement.x != 0 || currentMovement.y != 0;
        };
    }

    private void OnEnable()
    {
        movementControl.action.Enable();
    }

    private void OnDisable()
    {
        movementControl.action.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        isRunningHash = Animator.StringToHash("IsRunning");
        isChangingHash = Animator.StringToHash("IsChanging");
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        bool isRunning = animator.GetBool(isRunningHash);

        if(movementPressed && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }

        if(!movementPressed && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
