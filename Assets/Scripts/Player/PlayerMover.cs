using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour, IPlayerMover
{
    [SerializeField] private float _speedOfTransfer;
    [SerializeField] private CollisionTransmitter _transmitter;
    public void Move()
    {
        _transmitter.TransmitPosition();
        transform.position = Vector3.Lerp(transform.position, _transmitter.ReturnPosition(), _speedOfTransfer);
    }
}
