using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Medjed;
    public GameObject Moses;

    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Medjed.active)
        {
            transform.position = Medjed.transform.position + offset;
        }
        else if (Moses.active)
        {
            transform.position = Moses.transform.position + offset;
        }
        
    }
}
