using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2 : Enemy                //This class is inheriting from the Enemy's class and overriding the update method to change score allocated for killin the enemy.
{
    public override void Update()
    {
        if (HealthPoint <= 0)
        {
            ScoreScript.scoreValue += 30;   //If the enemy is killed, the score value will increase by 30.
            gameObject.SetActive(false);    //The game object will disappear when the enemy's health is less than 0.

        }
    }
}
