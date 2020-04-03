using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_ : MonoBehaviour {
    public float speed;
    Rigidbody2D rb;
    public float move;
    bool facingRight = true;

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
	}
	
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(move));

        if (move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180f, 0);
    }
	
	void FixedUpdate () {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * speed, 0);
	}
}
