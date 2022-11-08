using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour, IGameLogic
{
    [SerializeField] private Stick _stick;
    [SerializeField] private Player _player;
    public void Fail()
    {
        throw new System.NotImplementedException(); //display Fail UI
    }

    public void Pass()
    {
        _stick.GetComponent<IStickInstantiator>().Instantiate();//Instantiate new prefab, move player

    }
}
