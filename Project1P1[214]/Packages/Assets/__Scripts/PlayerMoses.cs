using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMoses : MonoBehaviour
{
    public static int maxHealth = 100;
    public static int currentHealth;
    public LayerMask damaged;
    public Transform damageCheck;
    public float DamageRadius = .2f;
    public int damage = 20;
    //public int heal = 15;
    public Health healthBar;
    public GameObject gameOverText, mainMenuButton, bloodSplash;
    // Start is called before the first frame update
    void Awake()
    {
        gameOverText.SetActive(false);
        mainMenuButton.SetActive(false);
        currentHealth = maxHealth;

    }

    void Restart()
    {
        //restarting game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    /*public void Healling(int heal)
    {
        currentHealth += heal;
    }*/
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            TakeDamage(damage);
        }
        /*if (col.gameObject.tag.Equals("HealthPickup"))
        {
            Destroy(col.gameObject);
            Healling(heal);
        }*/
        if (currentHealth <= 0)
        {
            gameOverText.SetActive(true);
            mainMenuButton.SetActive(true);
            Instantiate(bloodSplash, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
