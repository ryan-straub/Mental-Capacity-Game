using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class Stopwatch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool stopWatchActive = false;
    float currentTime;
    public Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopWatchActive== true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Seconds.ToString() + ":" + time.Milliseconds.ToString();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        StartStopwatch();
    }

     public void OnPointerUp(PointerEventData eventData)
    {
        StopStopwatch();
    }

    public void StartStopwatch()
    {
        stopWatchActive = true;
    }
     
    public void StopStopwatch()
    {
        stopWatchActive = false;
        if (stopWatchActive == false)
        {
            if(currentTime > 29.000 && currentTime < 30.000)
            {
                SceneManager.LoadScene(8);
            }
            else
            {
                SceneManager.LoadScene(7);
            }
        }
    }
}

