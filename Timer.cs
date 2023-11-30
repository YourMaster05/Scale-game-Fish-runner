using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TextMeshPro timeText;

    public GameObject panel;
    public TextMeshProUGUI scalesAmount;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        panel.SetActive(false);
        GameObject player = GameObject.Find("Player");
        player.GetComponent<Collider2D>().enabled = true;

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
            }
        }

        if(timeRemaining == 0)
        {
            panel.SetActive(true);
            GameObject player = GameObject.Find("Player");
            player.GetComponent<Collider2D>().enabled = false;
        }

        scalesAmount.text = "Got " + Player.score + "/100 scales";
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}