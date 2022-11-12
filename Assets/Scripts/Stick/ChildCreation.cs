using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChildCreation : MonoBehaviour, IStickInitializer
{
    [SerializeField] private TransformUnityEvent _onStickInstantiated;
    [SerializeField] private CollisionDetection _collisionDetection;
    public Transform _instance { get; private set; }

    public void Initialize()
    {
        _instance = Instantiate(this, _collisionDetection._collisionPosition, Quaternion.identity).transform;
        IEnumerator PrepareStick()
        {
            yield return new WaitForSeconds(.1f);
            _instance.GetComponent<InputController>().TurnOn();
            _instance.GetComponent<StickGrower>().ResetScale();
        }
        StartCoroutine(PrepareStick());
    }

    
}
