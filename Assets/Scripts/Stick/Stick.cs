using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour {
	private IStickInstantiator _stickInstantiator;
	private IStickGrower _stickGrower;
	private IStickRotator _stickRotator;
	private IStickLocker _stickLocker;
	private void Awake()
	{
		_stickInstantiator = GetComponent<IStickInstantiator>();
		_stickGrower = GetComponent<IStickGrower>();
		_stickRotator = GetComponent<IStickRotator>();
		_stickLocker = GetComponent<IStickLocker>();
	}
}
