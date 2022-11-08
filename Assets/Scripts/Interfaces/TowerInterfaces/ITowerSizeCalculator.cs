using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface ITowerSizeCalculator
{
    void GenerateTowerSize();
    float GetSize();
}