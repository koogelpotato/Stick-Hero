using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionTransmitter : MonoBehaviour, ICollisionTransmitter, IReturnPosition
{
    private Vector3 _transformPos;

    public Vector3 ReturnPosition()
    {
        return _transformPos;
    }

    public void TransmitPosition()
    {
        _transformPos = new Vector3(transform.position.x,transform.position.y,0);
    }
}
