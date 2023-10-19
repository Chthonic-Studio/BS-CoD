using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    private float vertical;
    private float speed = 3f;
    private bool isLadder;
    private Animator animator;
    private bool isClimbing;

    [SerializeField] private Rigidbody2D rb;

    //Update is called once per frame

    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        animator = GetComponent<Animator>();

        if (isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
            animator.SetBool("IsClimbing", true);
            animator.SetBool("IsClimbingStatic", false);
        }

        //If player is climbing but not moving, set animation to static
        if (isClimbing && Mathf.Abs(vertical) == 0f)
        {
            animator.SetBool("IsClimbingStatic", true);
        }

    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        } 
        else 
        {
            rb.gravityScale = 3f;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = false;
            isClimbing = false;
            animator.SetBool("IsClimbing", false);
            animator.SetBool("IsClimbingStatic", false);
        }
    }

}
