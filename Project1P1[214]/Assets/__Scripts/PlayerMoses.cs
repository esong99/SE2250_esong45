using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoses : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    /*public LayerMask damaged;
    public Transform damageCheck;
    public float DamageRadius = .2f;
    public int damage = 30;
    public int enemyDamage = 60;*/
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        /*Collider2D[] colliderD = Physics2D.OverlapCircleAll(damageCheck.position, DamageRadius, damaged);
        for (int i = 0; i < colliderD.Length; i++)
        {
            if (colliderD[i].gameObject == gameObject)
            {
                TakeDamage(damage);
            }
        }*/
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        /*Transform rootT = other.gameObject.transform.root;
        GameObject go = rootT.gameObject;

        if (go.tag == "Enemy")
        {
            TakeDamage(damage);
        }
        else
        {
            print("Triggered by non-Enemy: " + go.name);
        }*/
        /*if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SendMessage("OnDamage", damaged);
            TakeDamage(damage);
        }*/
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
