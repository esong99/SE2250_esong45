using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck2 : BoundsCheck
{

    public override void LateUpdate()
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


}