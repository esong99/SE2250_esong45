using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    Vector3 localScale;
    //Player health = new Player();

    // Start is called before the first frame update
   private void Start()
    {
       
        localScale = (transform.localScale);
    }
   
    private void Update()
    {
        localScale.x = (Player.currentHealth)/12;
        transform.localScale = localScale;
    }
}
