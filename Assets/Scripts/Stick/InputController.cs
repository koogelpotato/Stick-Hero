using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour,IInputController
{
    private InputHandler _inputHandler;
    private void Start()
    {
        _inputHandler = transform.GetComponent<InputHandler>();
    }
    public void TurnOff()
    {
        _inputHandler.enabled = false;
    }

    public void TurnOn()
    {
        _inputHandler.enabled = true;
    }
}
