using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_InputField answareInput;
    public AppleBoxesController boxes;
    public FireWorkController fireWork;
    public SheepsController sheeps;
    public SheepsController animals;

    public int result = -1;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SetNumber(KeyCode.Alpha0, "0");
        SetNumber(KeyCode.Alpha1, "1");
        SetNumber(KeyCode.Alpha2, "2");
        SetNumber(KeyCode.Alpha3, "3");
        SetNumber(KeyCode.Alpha4, "4");
        SetNumber(KeyCode.Alpha5, "5");
        SetNumber(KeyCode.Alpha6, "6");
        SetNumber(KeyCode.Alpha7, "7");
        SetNumber(KeyCode.Alpha8, "8");
        SetNumber(KeyCode.Alpha9, "9");

        if (Input.GetKey(KeyCode.Backspace) || Input.GetKey(KeyCode.Delete))
        {
            answareInput.text = "";
        }

        var resultNumber = 0;

        try
        {
            resultNumber = Int32.Parse(answareInput.text);
        } catch (Exception exc)
        {
            // Debug.LogError(exc);
        }

        SetState(resultNumber);
    }

    public void AddNumber(int number)
    {
        answareInput.text += number.ToString();
    }

    void SetState(int resultNumber)
    {
        if (result == resultNumber)
        {
            fireWork.Invoke();

            answareInput.text = "";

            boxes.SetQuestion();

            score++;

            int tens = Mathf.FloorToInt(score / 10);

            animals.SetSheepCount(tens);
            sheeps.SetSheepCount(score - (tens * 10));
        }
    }

    void SetNumber(KeyCode key, string text)
    {
        if (Input.GetKeyDown(key))
        {
            answareInput.text += text;
        }

    }

}
