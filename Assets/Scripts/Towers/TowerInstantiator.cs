using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerInstantiator : MonoBehaviour, ITowerInstantiator
{
    [SerializeField] private Transform _pillarTransform;
    private ITowerSizeCalculator _sizeCalc;
    private IDistanceCalculator _distanceCalc;

    private Vector3 _offSet;
    private Vector3 _scale;
    private void Awake()
    {
        _distanceCalc = GetComponent<IDistanceCalculator>();
        _sizeCalc = GetComponent<ITowerSizeCalculator>();
    }
    public void Initialize()
    {
        _distanceCalc.GenerateTowerDistance();
        _sizeCalc.GenerateTowerSize();
        _offSet = (transform.position += new Vector3(_distanceCalc.GetDistance(),_offSet.y));
        _scale = new Vector3(_sizeCalc.GetSize(), transform.localScale.y);
        _pillarTransform.localScale = _scale;
    }
    public void SpawnTower()
    {
        Instantiate(_pillarTransform, _offSet,Quaternion.identity);
    }
}
