using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck2 : MonoBehaviour
{

    [Header("Set in Inspector")]
    public float radius = 1f;
    public bool keepOnScreen = true;

    [Header("Set Dynamically")]
    public bool isOnScreen = true;
    public float camWidth;
    public float camHeight;
    [HideInInspector]
    public bool offRight, offLeft, offUp, offDown;

    void Awake()
    {
        camHeight = Camera.main.orthographicSize;
        camWidth = camHeight * Camera.main.aspect;

    }
    void LateUpdate()
    {
        Vector3 pos = transform.position;
        isOnScreen = true;
        offRight = offLeft = offUp = offDown = false;
        if (pos.x > 213)
        {
            pos.x = 213;
            offRight = true;
        }
        if (pos.x < -13)
        {
            pos.x = -13;
            offLeft = true;
        }
        if (pos.y > 30)
        {
            pos.y = 30;
            offUp = true;
        }
        if (pos.y < -12)
        {
            pos.y = -12;
            offDown = true;
        }
        isOnScreen = !(offRight || offLeft || offUp || offDown);
        if (keepOnScreen && !isOnScreen)
        {
            transform.position = pos;
            isOnScreen = true;
            offRight = offLeft = offUp = offDown = false;
        }

    }
    void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;
        Vector3 boundSize = new Vector3(camWidth * 2, camHeight * 2, 0.1f);
        Gizmos.DrawWireCube(Vector3.zero, boundSize);

    }


}