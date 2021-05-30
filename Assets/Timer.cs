using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    float worktime = 25*60;
    float shorttime = 5*60;
    float longtime = 10*60;
    public bool timerIsRunning = false;
    public Text timeText;
    public GameObject audioPlayer;

    // for settings
    public GameObject timeType;
    public GameObject digit1;
    public GameObject digit2;

    public void start_time()
    {
        timerIsRunning = true;
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
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                AudioSource audioSource = audioPlayer.GetComponent<AudioSource>();
                audioSource.Play();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void workTime() {
        timeRemaining = worktime;
        DisplayTime(timeRemaining);
    }

    void shortBreak() {
        timeRemaining = shorttime;
        DisplayTime(timeRemaining);
    }

    void longBreak() {
        timeRemaining = longtime;
        DisplayTime(timeRemaining);
    }

    void changeTime() {
        string dig1 = digit1.GetComponent<Text>().text;
        string dig2 = digit2.GetComponent<Text>().text;
        string temp = dig1 + dig2;
        if (timeType.GetComponent<Text>().text == "Work Time") {
            worktime = (float) int.Parse(temp);
            worktime *= 60;
            timeRemaining = worktime;
        } else if (timeType.GetComponent<Text>().text == "Short Break") {
            shorttime = (float) int.Parse(temp);
            shorttime *= 60;
            timeRemaining = shorttime;
        } else { // Long Break
            longtime = (float) int.Parse(temp);
            longtime *= 60;
            timeRemaining = longtime;
        }
        DisplayTime(timeRemaining);
    }
}