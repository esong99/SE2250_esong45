using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    //Weapon damage;
    Weapon damage;
    public int damageBonus = 15;
    void Awake()
    {
        //damage = FindobjectofType<Weapon>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)

    {
        Destroy(gameObject);
        Weapon.damage = Weapon.damage + damageBonus;
    }
}
