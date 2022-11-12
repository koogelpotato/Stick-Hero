using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickGrower : MonoBehaviour, IStickGrower,IStickReseter
{
    [SerializeField] private float _speed;

    [SerializeField] private Vector3 _initialScale;
    public void Grow()
    {
        var scale = transform.localScale;
        scale.y += _speed * Time.deltaTime;
        transform.localScale = scale;
    }

    public void ResetScale()
    {
        transform.localScale = _initialScale;
    }
}
