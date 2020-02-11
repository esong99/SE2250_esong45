using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public LayerMask damaged;
    public Transform damageCheck;
    public float DamageRadius = .2f;
    public int damage = 5;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] colliderD = Physics2D.OverlapCircleAll(damageCheck.position, DamageRadius, damaged);
        for (int i = 0; i < colliderD.Length; i++)
        {
            if (colliderD[i].gameObject == gameObject)
            {
                TakeDamage(damage);
            }
        }
        if (currentHealth == 0)
        {
            Invoke("Restart", 3.0f);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

    }
    void Restart()
    {
        //restarting game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
