using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDistanceGenerator : MonoBehaviour, IDistanceCalculator
{
    [SerializeField] private float _minDistance;
    [SerializeField] private float _maxDistance;
    private float _distance;
    public void GenerateTowerDistance()
    {
        _distance = Random.Range(_minDistance, _maxDistance);
    }

    public float GetDistance()
    {
        return _distance;
    }
}
