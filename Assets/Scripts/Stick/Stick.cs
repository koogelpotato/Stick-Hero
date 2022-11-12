using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour {
	private IStickInitializer _stickInitializer;
	private IStickGrower _stickGrower;
	private IStickRotator _stickRotator;
	private IStickLocker _stickLocker;
	private IStickMover _stickMover;
	private IInputController _inputRemover;
	private IStickReseter _stickReseter;
	private void Awake()
	{
		_stickInitializer = GetComponent<IStickInitializer>();
		_stickGrower = GetComponent<IStickGrower>();
		_stickRotator = GetComponent<IStickRotator>();
		_stickLocker = GetComponent<IStickLocker>();
		_inputRemover = GetComponent<IInputController>();
		_stickMover = GetComponent<IStickMover>();
		_stickReseter = GetComponent<IStickReseter>();
	}
}
