using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickupMoses : MonoBehaviour
{
    //Weapon damage;
    CaneAttack damage;
    public int damageBonus = 15;
    void Awake()
    {
        //damage = FindobjectofType<Weapon>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)

    {
        Destroy(gameObject);
        CaneAttack.damage = CaneAttack.damage + damageBonus;
    }
}
