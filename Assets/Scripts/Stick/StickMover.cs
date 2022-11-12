using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StickMover : MonoBehaviour, IStickMover
{
    [SerializeField] private CollisionDetection _collisionDetection;
    [SerializeField] private UnityEvent _onStickMoved;
    public void Move(Transform stickInstance)
    {
        stickInstance.transform.position = Vector3.Lerp(transform.position, _collisionDetection._collisionPosition, 1f);
        _onStickMoved?.Invoke();
    }
}
