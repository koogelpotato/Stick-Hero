using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour, IInputHandler
{
    private bool _buttonPress;
    private bool _buttonRelease;
    [SerializeField]
    private KeyCode _keyCode;
    [SerializeField]
    private UnityEvent OnButtonPressed;
    [SerializeField]
    private UnityEvent OnButtonReleased;
    public void GetInput()
    {
        _buttonPress = Input.GetKey(_keyCode);
        _buttonRelease = Input.GetKeyUp(_keyCode);
    }

    public void SendAction()
    {
        if(_buttonPress)
        {
            OnButtonPressed?.Invoke();
        }
        if(_buttonRelease)
        {
            OnButtonReleased?.Invoke();
        }
    }
    
    private void Update()
    {
        GetInput();
        SendAction();
    }
}
