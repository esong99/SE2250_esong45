using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    public GameObject Moses;
    public GameObject Medjed;

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(","))
        {
            Moses.transform.position = Medjed.transform.position;
            Medjed.gameObject.SetActive(false);
            Moses.gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown("."))
        {
            Medjed.transform.position = Moses.transform.position;
            Moses.gameObject.SetActive(false);
            Medjed.gameObject.SetActive(true);
        }
    }
}
