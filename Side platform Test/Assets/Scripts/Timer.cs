using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static Timer instance { get; private set; }
    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
       
        timerIsRunning = false;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                //Display function call goes here
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    public void SetTimerRunning(bool inRunning)
    {
        timerIsRunning = inRunning;
    }

    public bool GetTimerRunning()
    {
        return timerIsRunning;
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        //timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
