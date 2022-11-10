using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameLogic : MonoBehaviour, IGameLogic
{
    [SerializeField] private CollisionDetection _collisionDetection;
    [SerializeField] private UnityEvent _onLevelPassed;
    [SerializeField] private Stick _stick;

    
    public void Fail()
    {
        Debug.Log("failed"); //display Fail UI
    }

    public void Pass()
    {
        _collisionDetection.Reset();
        _stick.GetComponent<IStickMover>().Move(_collisionDetection._collisionPosition);
        _stick.GetComponent<IStickInstantiator>().Instantiate();
        // TO DO Problem occurs because the gamelogic tries to access the allready used stick
    }

    public void Determine()
    {
        IEnumerator GameLoop()
        {
            yield return new WaitForSeconds(.1f);
            if (_collisionDetection._collided)
                Pass();
            else
                Fail();
        }
        StartCoroutine(GameLoop());
    }
}
