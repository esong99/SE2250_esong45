using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rigidbody2d;
    private bool FacingRight = true;
    public Animator animator;
    const float GroundedRadius = .2f;
    public LayerMask WhatIsGround;
    public Transform GroundCheck;
    private bool Grounded;
    public bool AirCommands = false;
    private Vector3 Velocity = Vector3.zero;
    public float MovementSmoothing = .05f;
    public float jumpVelocity = 400f;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    void FixedUpdate()
    {
        Grounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(GroundCheck.position, GroundedRadius, WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject||Input.GetButtonDown("Jump"))
            {
                Grounded = true;
            }
            if (Grounded||AirCommands)
            {
                float moveHorizontal = Input.GetAxis("Horizontal")*speed;

                animator.SetFloat("speed", Mathf.Abs(moveHorizontal));

                Vector3 targetVelocity = new Vector2(moveHorizontal, rigidbody2d.velocity.y);
                rigidbody2d.velocity = Vector3.SmoothDamp(rigidbody2d.velocity, targetVelocity, ref Velocity, MovementSmoothing);


                if (moveHorizontal > 0 && !FacingRight)
                {
                    Flip();
                }
                else if (moveHorizontal < 0 && FacingRight)
                {
                    Flip();
                }
            }

            if (Grounded&&Input.GetButtonDown("Jump"))
            {
                rigidbody2d.AddForce(new Vector2(0f, jumpVelocity));
            }
        }

        if (direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                direction = 2;
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rigidbody2d.velocity = Vector3.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;
            }
            if (direction == 1)
            {
                rigidbody2d.velocity = Vector3.left * dashSpeed;
            }
            else if (direction == 2)
            {
                rigidbody2d.velocity = Vector3.right * dashSpeed;
            }

        }

        
        if (Input.GetKeyDown("g"))
        {
            animator.SetTrigger("isDancing");
        }
        

    }
    private void Flip()
    {
        FacingRight = !FacingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
