using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StickRotator : MonoBehaviour, IStickRotator
{
    [SerializeField] private float _finalRotation;
    [SerializeField] private float _speedOfRotation;
    [SerializeField] private UnityEvent _onStickRotated;
    private float _currentRotation;
    public void Rotate()
    {
        while (_currentRotation <= _finalRotation)
        {
            _currentRotation += _speedOfRotation * Time.deltaTime;
            transform.eulerAngles = new Vector3(0,0,_currentRotation);
        }
        if (_currentRotation >= _finalRotation)
            _onStickRotated?.Invoke();
    }
}
