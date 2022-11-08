using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private UnityEvent _onCollisionEnter;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<ICollidable>() != null)
        {
            if (_onCollisionEnter != null)
            {
                _onCollisionEnter.Invoke();
            }
        }
    }
}
