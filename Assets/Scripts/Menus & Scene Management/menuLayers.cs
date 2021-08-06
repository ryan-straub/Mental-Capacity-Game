using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuLayers : MonoBehaviour
{

    public GameObject mainMenuOverlay;
    public GameObject creditsOverlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void credits()
    {
        mainMenuOverlay.SetActive(false);
        creditsOverlay.SetActive(true);
    }

    public void mainMenu()
    {
        mainMenuOverlay.SetActive(true);
        creditsOverlay.SetActive(false);
    }

}
