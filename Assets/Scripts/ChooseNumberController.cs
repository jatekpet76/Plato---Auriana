using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChooseNumberController : MonoBehaviour
{
    public int number = 1;
    public TextMeshPro numberText;

    void Start()
    {
        numberText.SetText(number.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
