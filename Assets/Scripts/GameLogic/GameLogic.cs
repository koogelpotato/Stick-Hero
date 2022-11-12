using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameLogic : MonoBehaviour, IGameLogic
{
    [SerializeField] private CollisionDetection _collisionDetection; //collision point of a child gameobject with 2D collider attached
    [SerializeField] private UnityEvent _onLevelPassed;
    [SerializeField] private UnityEvent _onLevelFailed;//currently unused event 
    private void Awake()
    {
        
    }
    public void Fail()
    {
        _onLevelFailed?.Invoke(); //display Fail UI
    }
    public void Pass()
    {
        _onLevelPassed?.Invoke();//instantiates the stick at collision point
    }
    public void Determine() // calls the functions based on whether or not the stick collided with the pillar
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
