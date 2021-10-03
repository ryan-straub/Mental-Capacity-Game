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
    public GameObject HandWashing;
    public GameObject Fade;
    public GameObject Bubbles;
    public AudioSource sinkNoise;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    // When stopwatch starts
    void Update()
    {
        if (stopWatchActive== true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Seconds.ToString() + ":" + time.Milliseconds.ToString();
    }

    //Plays Handwashing, Bubbles, and Fading Animation while the WASH! button is held down
    public void OnPointerDown(PointerEventData eventData)
    {
        StartStopwatch();
        HandWashing.GetComponent<Animator>().Play("HandWashing");
        Fade.GetComponent<Animator>().Play("FadeEffect");
        Bubbles.GetComponent<Animator>().Play("bubbles");
        sinkNoise.Play();
    }

    //When wash button is released
     public void OnPointerUp(PointerEventData eventData)
    {
        StopStopwatch();
    }

    public void StartStopwatch()
    {
        stopWatchActive = true;
    }
    
    //When player releases the button checks to see if timer stops between alloted time.
    //If it does, then it move to the obstacle course, else it restarts the level
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

