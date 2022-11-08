using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerGenerator : MonoBehaviour
{
	private ITowerInstantiator _towerInstantiator;
	private void Awake()
    {
		_towerInstantiator = GetComponent<ITowerInstantiator>();
    }
	private void Start()
    {
		_towerInstantiator.Initialize();
		_towerInstantiator.SpawnTower();
    }
	
}
