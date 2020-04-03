using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChange : MonoBehaviour
{
    public GameObject Moses;
    public GameObject Medjed;

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("."))
        {
            Medjed.gameObject.SetActive(false);
            GameObject go = Instantiate<GameObject>(Moses);
        }
        else if (Input.GetKeyDown(","))
        {
            Moses.gameObject.SetActive(false);
            GameObject GO = Instantiate<GameObject>(Medjed);
        }
    }
}
