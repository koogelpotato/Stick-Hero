using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickInstantiator : MonoBehaviour, IStickInstantiator
{
    [SerializeField] private Transform _stickPrefab;
    public void Instantiate()
    {
        Instantiate(_stickPrefab);
    }
}
