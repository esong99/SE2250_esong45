using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    //Player playerHealth;
    Player maxHealth;
    Player currentHealth;
    public int healthBonus = 15;
    void Awake()
    {
       // playerHealth = FindObjectOfType<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(Player.currentHealth < Player.maxHealth)
        {
            Destroy(gameObject);
            Player.currentHealth = Player.currentHealth + healthBonus;
        }
    }
}
