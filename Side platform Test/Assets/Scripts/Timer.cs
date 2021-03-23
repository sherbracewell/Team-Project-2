using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer instance { get; private set; }
    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    public Text timeText;  

    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        timeText.text = "";
        timerIsRunning = false;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                SceneManager.LoadScene("GameOver");
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

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
