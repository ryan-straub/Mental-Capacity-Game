﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doot : MonoBehaviour
{
    public AudioSource dootSFX;
    
    //heh heh heh
    private void OnTriggerEnter2D(Collider2D other)
    {
        dootSFX.Play();
    }
}
