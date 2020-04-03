using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaneAttack : MonoBehaviour
{
    public Transform attackPos;
    public LayerMask WhatIsEnemies;
    public float attackRange;
    public int damage;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("Attacked");
                          
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, WhatIsEnemies);
            for(int i = 0; i < enemiesToDamage.Length; i++)
            {
                enemiesToDamage[i].GetComponent<Enemy>().HealthPoint -= damage;
            }
        }   
    }
}
