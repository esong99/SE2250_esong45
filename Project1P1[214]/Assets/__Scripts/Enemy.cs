using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HealthPoint = 100;
    public int Damage = 30;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(HealthPoint <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void TakeDamage(int damage)
    {
        HealthPoint -= damage;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
      // HealthPoint -= Damage;
    }
   
}
