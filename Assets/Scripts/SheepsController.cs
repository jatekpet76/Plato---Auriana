using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepsController : MonoBehaviour
{
    SheepController[] _sheeps;

    void Start()
    {
        _sheeps = GetComponentsInChildren<SheepController>();
    }
 
    public void SetSheepCount(int count)
    {
        foreach (SheepController sheep in _sheeps)
        {
            sheep.doSpin = (sheep.position < count + 1);
        }
    }
}
