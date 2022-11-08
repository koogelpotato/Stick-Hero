using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickLocker : MonoBehaviour, IStickLocker
{
    public void Lock()
    {
        transform.SetParent(null);
        Debug.Log("Excuted");
    }
}
