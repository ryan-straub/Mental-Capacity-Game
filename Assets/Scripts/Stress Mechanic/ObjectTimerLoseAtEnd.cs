using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

//https://www.youtube.com/watch?v=o0j7PdU88a4

public class ObjectTimerLoseAtEnd : MonoBehaviour
{
    public PlayerStress playerStress;
    public Text currentTimeText;
    public float startTime = 60f;
    public float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" +time.Seconds.ToString() + ":" + time.Milliseconds.ToString();

        if (currentTime >= 100)
        {
            playerStress.veryLargeStressIncrease();
        }
        else if (currentTime >= 80 && currentTime <= 99)
        {
            playerStress.veryLargeStressIncrease();
        }
        else if (currentTime >= 60 && currentTime <= 79)
        {
            playerStress.veryLargeStressIncrease();
        }
        else if (currentTime <= 0)
        {
            currentTime = 0;
            playerStress.gameOver();
        }
    }
}
