using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public string levelToLoad;
   
    void OnTriggerEnter2d(Collider2D other)
    {
        if (other.gameObject.tag == "Medjed"){
            Application.LoadLevel(levelToLoad);
        }
    }
}
