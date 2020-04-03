using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupMoses : MonoBehaviour
{
    //Player playerHealth;
    PlayerMoses maxHealth;
    PlayerMoses currentHealth;
    public int healthBonus = 15;
    void Awake()
    {
        // playerHealth = FindObjectOfType<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (PlayerMoses.currentHealth < PlayerMoses.maxHealth)
        {
            Destroy(gameObject);
            PlayerMoses.currentHealth = PlayerMoses.currentHealth + healthBonus;
        }
    }
}
