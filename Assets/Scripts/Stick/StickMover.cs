using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMover : MonoBehaviour, IStickMover
{
    public void Move(Vector2 position)
    {
        transform.position = position;
    }
}
