using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class LightSwitchTrigger : MonoBehaviour
{
    public GameObject doorButtonTrigger;
    public OpenDoorLightSwitch lightSwitch;
    public Sprite LightSwitchOff;
    public AudioSource buttonClick;
    private bool isOff = false;

    //When the program starts, it deactivates all the switches
    public void Awake()
    {
        lightSwitch = FindObjectOfType<OpenDoorLightSwitch>();
        buttonClick = GetComponent<AudioSource>();
    }

    //When light switch is turned off, then it plays sfx
    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (!isOff)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = LightSwitchOff;
            lightSwitch.addLight();
            buttonClick.Play();
            isOff = true;

        }
    }




}
