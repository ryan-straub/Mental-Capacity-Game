using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuLayers : MonoBehaviour
{
    public GameObject mainMenuOverlay;
    public GameObject creditsOverlay;
    public GameObject musicCreditsOverlay;

    //Main Menu overlay transitions 

    public void mainMenuToCredits()
    {
        mainMenuOverlay.SetActive(false);
        creditsOverlay.SetActive(true);
    }

    public void creditsToMainMenu()
    {
        mainMenuOverlay.SetActive(true);
        creditsOverlay.SetActive(false);
    }

    public void musicToCredits()
    {
        creditsOverlay.SetActive(true);
        musicCreditsOverlay.SetActive(false);
    }

    public void creditsToMusic()
    {
        musicCreditsOverlay.SetActive(true);
        creditsOverlay.SetActive(false);
    }

}
