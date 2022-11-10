using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour, IPlayerMover
{
    [SerializeField] private float _speedOfTransfer;
    [SerializeField] private CollisionDetection _collisionPoint;

    public void Move(Vector2 position)
    {
        transform.position = new Vector2(position.x, transform.position.y);
    }

    private void Awake()
    {
        
    }
    
}
