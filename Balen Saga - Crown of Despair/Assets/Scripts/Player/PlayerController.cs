using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Basic movement and jumping
    public float speed;
    public float jumpForce = 4f;
    private Rigidbody2D rb;
    private bool isGrounded;
    private BoxCollider2D coll;
    private Animator animator;
    bool facingRight = true;
    [SerializeField] private LayerMask jumpableGround;
    //Stamina and running
    public float stamina = 100f;
    public float runSpeed = 7f;
    public float walkSpeed = 3f;
    public float drainRate = 1f;
    public float reChargeRate = 1f; 
    public float fatigueTimer = 0f;
    bool isFatigued;
    bool isRunning;
    public float exponentialPenalty = 1f;
    //Dashing
    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;
    [SerializeField] private TrailRenderer tr;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        //Check if dashing
        if (isDashing)
        {
            return;
        }
        
        // Horizontal movement
        float move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(move));

        if (isRunning = true)
        {
            speed = 5f;
        }

        //Flip sprite when moving left

        if (move > 0 && !facingRight)
        {
            Flip();
        }

        if (move < 0 && facingRight)
        {
            Flip();
        }

        // Jump if player is on ground
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

            animator.SetBool("IsJumping", true);

        }

        // If player vertical velocity is 0, isGrounded is true

        if (rb.velocity.y == 0)
        {
            isGrounded = true;
        }

        // If player is going down in y axis, animator setBool for Falling is true
        
        if (rb.velocity.y < 0)
        {
            animator.SetBool("Falling", true);
        }

        else
        {
            animator.SetBool("Falling", false);
        }

        //Running and stamina

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (stamina > 0 && !isFatigued)
            {
                speed = runSpeed;
                isRunning = true;
                animator.SetBool("IsRunning", true);
            }
            else

            if (isRunning || isFatigued)
            {
                speed = walkSpeed;
                isRunning = false;
                animator.SetBool("IsRunning", false);

                exponentialPenalty = 1;
            }

            exponentialPenalty += Time.deltaTime/20f;
        
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (isRunning || isFatigued)
            {
                speed = walkSpeed;
                isRunning = false;
                animator.SetBool("IsRunning", false);
            }
        }

        if (!Input.GetKey(KeyCode.LeftShift) && exponentialPenalty>1)
        {
            exponentialPenalty -= Time.deltaTime / 20f;
            if (exponentialPenalty < 1)
            {
                exponentialPenalty = 1f;
            }
        }

        if (isRunning)
        {
            stamina -= (Time.deltaTime * drainRate) * exponentialPenalty;
            stamina += Time.deltaTime * reChargeRate;
        }
        else
        
        if(!isFatigued)
        {
            stamina += Time.deltaTime * reChargeRate;
        }

        //if (!isRunning && stamina > 0 && stamina <100 )
        //{
          //  stamina += Time.deltaTime * reChargeRate;
        //}
 
        if (stamina <= 0f && fatigueTimer <= 3)
        {
            fatigueTimer += Time.deltaTime;
            isFatigued = true;
        }
        else
 
        if (fatigueTimer >= 3)
        {
            stamina += Time.deltaTime * reChargeRate;
            isFatigued = false;
            fatigueTimer = 0;
        }
 
        if(stamina < 0f)
        {
            stamina = 0f;
        }
 
        if (stamina > 100f)
        {
            stamina = 100f;
        }

        //Dashing

        if (Input.GetKeyDown(KeyCode.LeftControl) && canDash)
        {
            StartCoroutine(Dash());
        }

        //Check if running

        if (speed == runSpeed)
        {
            animator.SetBool("IsRunning", true);
        }
        if (speed < runSpeed)
        {
            animator.SetBool("IsRunning", false);
        }

        //Check if dashing by checking if trail renderer is emitting

        if (tr.emitting)
        {
            animator.SetBool("IsDashing", true);
        }
        else
        {
            animator.SetBool("IsDashing", false);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("IsJumping", false);
        }

    if (collision.gameObject.CompareTag("Player") && collision.gameObject.CompareTag("Enemy"))
        {
        // Prevent pushing by disabling any physics forces
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
       
    //Flip sprite when moving left
    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }

    private void FixedUpdate()
    {
        HandleLayers();
        if (isDashing)
        {
            return;
        }
    }

    private void HandleLayers()
    {
        if (!isGrounded)
        {
            animator.SetLayerWeight(1, 1);
        }
        else
        {
            animator.SetLayerWeight(1, .5f);
        }
    }
    
    //Dash and trail renderer

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
        
    }

}