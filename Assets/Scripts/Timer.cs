using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timerValue;
    [SerializeField] float timeToAnswer = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    public bool isAnsweringQuestion = false;

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (timerValue <= 0)
        {
            if (isAnsweringQuestion)
            {
                timerValue = timeToAnswer;
                isAnsweringQuestion = false; // End the answering phase
            }
            else
            {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = true;  
            }
        }
        Debug.Log("Timer Value: " + timerValue);
    }
}
