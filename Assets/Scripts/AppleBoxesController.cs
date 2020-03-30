using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppleBoxesController : MonoBehaviour
{
    AppleBoxController[] _boxes;

    public TextMeshProUGUI numberText;
    public GameController controller;

    int _baseNumber = 6;
    int _times = 7;



    void Start()
    {
        _boxes = GetComponentsInChildren<AppleBoxController>();

        SetQuestion();
    }

    public void SetQuestion()
    {
        _baseNumber = Random.Range(1, 10);
        _times = Random.Range(1, 10);

        Operators operatorType = (Random.Range(0, 10) % 2 == 0)? Operators.TIMES: Operators.DIVIDE;

        if (operatorType == Operators.DIVIDE)
        {
            numberText.SetText((_times * _baseNumber).ToString() + " / " + _baseNumber.ToString() + " = ");

            controller.result = _times;
        }
        else
        {
            numberText.SetText(_times.ToString() + " * " + _baseNumber.ToString() + " = ");

            controller.result = _baseNumber * _times;
        }

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

enum Operators
{
    TIMES, DIVIDE
}
