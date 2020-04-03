using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementMoses : MonoBehaviour
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
    float moveHorizontal = 0f;

    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        Grounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(GroundCheck.position, GroundedRadius, WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject || Input.GetButtonDown("Jump"))
            {
                Grounded = true;
            }
            if (Grounded || AirCommands)
            {
                moveHorizontal = Input.GetAxis("Horizontal") * speed;
                animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

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

            if (Grounded && Input.GetButtonDown("Jump"))
            {
                rigidbody2d.AddForce(new Vector2(0f, jumpVelocity));
            }
        }
    }
    private void Flip()
    {
        FacingRight = !FacingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
