using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HealthPoint = 100;       //Initializing the enemy's health and his damage upon attack by player.
    public int Damage = 30;
    

    // Update is called once per frame
    public virtual void Update()
    {
        if(HealthPoint <= 0)
        {
            ScoreScript.scoreValue += 10;       //If the enemy is killed, the score value will increase by 10.
            gameObject.SetActive(false);        //The game object will disappear when the enemy's health is less than 0.

        }
    }
    public void TakeDamage(int damage)
    {
        HealthPoint -= damage;                      //This function reduces the health of the enemy by the damage amount set.
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
      // HealthPoint -= Damage;
    }
   
}
