using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSlateAttack : MonoBehaviour
{
    public Animator animator;
    public int SelfDamage = 10;
    public int EnemyDamage = 30;
    public LayerMask WhatIsEnemy;
    public GameObject Moses;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            animator.SetTrigger("Magic");

            var objectsWithTag = GameObject.FindGameObjectsWithTag("Enemy");
            GameObject closestObject = null;
            foreach (GameObject obj in objectsWithTag)
            {
                if (closestObject==null)
                {
                    closestObject = obj;
                }
                //compares distances
                if (Vector3.Distance(transform.position, obj.transform.position) <= Vector3.Distance(transform.position, closestObject.transform.position))
                {
                    closestObject = obj;
                }
            }

            Moses.GetComponent<PlayerMoses>().currentHealth -= SelfDamage;

            closestObject.GetComponent<Enemy>().HealthPoint -= EnemyDamage;
        }
    }
}
