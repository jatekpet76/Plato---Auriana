using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AppleBoxController : MonoBehaviour
{
    AppleController[] _apples;

    public int appleCount = 5;
    public int position = 1;

    public TextMeshPro numberText;
    public TextMeshPro positionText;

    void Start()
    {
        _apples = GetComponentsInChildren<AppleController>();

        positionText.SetText(position + ".");
    }

    // Update is called once per frame
    void Update()
    {
        SetVisibleApples(appleCount);
    }

    public void SetVisibleApples(int apples)
    {
        numberText.SetText(apples.ToString());

        foreach (AppleController apple in _apples)
        {
            apple.gameObject.SetActive(!(apple.position > appleCount));
        }
    }
}
