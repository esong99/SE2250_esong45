using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_3 : Enemy
{
    public GameObject blood;
    public override void Update()
    {
        if (HealthPoint <= 0)
        {
            ScoreScript.scoreValue += 30;   //If the enemy is killed, the score value will increase by 20.
            gameObject.SetActive(false);    //The game object will disappear when the enemy's health is less than 0.
            Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(blood);

        }
    }
}
