using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	private IPlayerMover _playerMover;
	private void Awake()
    {
        _playerMover = GetComponent<IPlayerMover>();
    }
}
