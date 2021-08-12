using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuLayers : MonoBehaviour
{
    public GameObject mainMenuOverlay;
    public GameObject creditsOverlay;
    public GameObject optionsOverlay;

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

    public void optionsToMainMenu()
    {
        mainMenuOverlay.SetActive(true);
        optionsOverlay.SetActive(false);
    }

    public void mainMenuToOptions()
    {
        optionsOverlay.SetActive(true);
        mainMenuOverlay.SetActive(false);
    }

}
