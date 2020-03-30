using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppleBoxesController : MonoBehaviour
{
    AppleBoxController[] _boxes;

    public TextMeshProUGUI numberText;

    int _baseNumber = 6;
    int _times = 7;


    void Start()
    {
        _boxes = GetComponentsInChildren<AppleBoxController>();

        SetQuestion();
    }

    void SetQuestion()
    {
        _baseNumber = Random.Range(1, 10);
        _times = Random.Range(1, 10);

        numberText.SetText(_baseNumber.ToString() + " * " + _times.ToString() +" = ");

        foreach (AppleBoxController box in _boxes)
        {
            if (box.position < _times+1)
            {
                box.appleCount = _baseNumber;
            } 
            else
            {
                box.appleCount = 0;
            }
            
        }
    }

    void Update()
    {
        
    }
}
