using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSizeGenerator : MonoBehaviour, ITowerSizeCalculator
{
    [SerializeField] private float _minTowerScale;
    [SerializeField] private float _maxTowerScale;
    private float _towerScale;
    public void GenerateTowerSize()
    {
        _towerScale = Random.Range(_minTowerScale, _maxTowerScale);
    }

    public float GetSize()
    {
        return _towerScale;
    }
}
