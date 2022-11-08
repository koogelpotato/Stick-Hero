using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickGrower : MonoBehaviour, IStickGrower
{
    [SerializeField] private float _speed;
    public void Grow()
    {
        var scale = transform.localScale;
        scale.y += _speed * Time.deltaTime;
        transform.localScale = scale;
    }
    
}
