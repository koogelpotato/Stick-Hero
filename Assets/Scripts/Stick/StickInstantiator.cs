using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickInstantiator : MonoBehaviour, IStickInstantiator
{
    [SerializeField] private Transform _stickPrefab;
    private Vector2 _instantiationPosition;
    public void Instantiate()
    {
        Instantiate(_stickPrefab, _instantiationPosition, Quaternion.identity);
    }
}
