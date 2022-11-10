using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputRemover : MonoBehaviour, IRemoveInput
{
    private InputHandler _inputHandler;
    private void Start()
    {
        _inputHandler = transform.GetComponent<InputHandler>();
    }
    public void RemoveInput()
    {
        Destroy(_inputHandler);
    }

    
}
