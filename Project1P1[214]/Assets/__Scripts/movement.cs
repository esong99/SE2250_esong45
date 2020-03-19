using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement: MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D myRigidbody;
    public bool isWalking;
    public float walkTime;
    public float waitTime;
    private float walkCounter;
    private float waitCounter;
    private int WalkDirection;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        waitCounter = waitTime;
        walkCounter = walkTime;
        ChooseDirection();
    }
    void Update()
    {
        if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            switch (WalkDirection)
            {
                case 0:
                    myRigidbody.velocity = new Vector2(moveSpeed, 0);
                    break;
                case 1:
                    myRigidbody.velocity = new Vector2(moveSpeed, 0);
                    break;
                case 2:
                    myRigidbody.velocity = new Vector2(-moveSpeed*2, 0);
                    break;
                case 3:
                    myRigidbody.velocity = new Vector2(-moveSpeed*2, 0);
                    break;
            }
            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }


        }
        else
        {
            waitCounter -= Time.deltaTime;
            myRigidbody.velocity = Vector2.zero;
            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }
    public void ChooseDirection()
    {
        WalkDirection = Random.Range(0, 4);
        isWalking = true;
        walkCounter = walkTime;
    }

}