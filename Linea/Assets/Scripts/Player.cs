using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;

    private List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    private Rigidbody2D rb;
    private Animator animator;
    private InputManager inputManager;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        inputManager = InputManager.GetInstance();
    }

    public void FixedUpdate()
{
    DialogueManager dialogueManager = DialogueManager.GetInstance();

if (dialogueManager != null && dialogueManager.dialogueIsPlaying)
{
    return;
}

    Vector2 moveInput = inputManager.GetMoveDirection();

    if(moveInput != Vector2.zero)
    {
        bool success = MovePlayer(moveInput);

        if(!success)
        {
            success = MovePlayer(new Vector2(moveInput.x, 0));

            if(!success)
            {
                success = MovePlayer(new Vector2(0, moveInput.y));
            }
        }

        animator.SetFloat("XInput", moveInput.x);
        animator.SetFloat("YInput", moveInput.y);
        animator.SetBool("isMoving", success);
    } 
    else
    {
        animator.SetBool("isMoving", false);
    }
}

    public bool MovePlayer(Vector2 direction)
    {
        int count = rb.Cast(
            direction,
            movementFilter,
            castCollisions,
            moveSpeed * Time.fixedDeltaTime + collisionOffset);

        if (count == 0)
        {
            Vector2 moveVector = direction * moveSpeed * Time.fixedDeltaTime;

            rb.MovePosition(rb.position + moveVector);
            return true;
        }
        else
        {
            foreach (RaycastHit2D hit in castCollisions)
            {
                print(hit.ToString());
            }

            return false;
        }
    }
}