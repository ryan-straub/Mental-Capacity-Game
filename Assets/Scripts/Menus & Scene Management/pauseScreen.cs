using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScreen : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseOverlay;
    public AudioSource pauseSFX;
    public AudioSource pauseMusic;

    // Update is called once per frame
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            isPaused = true;
            Time.timeScale = 0;
            pauseSFX.Play();
            pauseOverlay.SetActive(true);

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            isPaused = false;
            Time.timeScale = 1;
            pauseOverlay.SetActive(false);
        }
    }

    public void unPause()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseOverlay.SetActive(false);
    }
}
