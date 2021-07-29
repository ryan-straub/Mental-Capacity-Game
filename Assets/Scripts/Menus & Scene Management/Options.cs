using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public float volume = 0;
    public float sfx = 0;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        slider.value = volume;
        slider.value = sfx;
    }
}
