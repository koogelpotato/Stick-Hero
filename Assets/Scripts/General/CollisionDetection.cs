using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionDetection : MonoBehaviour, IResetCollision
{
    public bool _collided { get; private set; } = false;
    public Vector2 _collisionPosition { get; private set; }

    public void Reset()
    {
        _collided = false;
        _collisionPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<ICollidable>() != null)
        {
            _collided = true;
            _collisionPosition = transform.position;
        }
    }



}
