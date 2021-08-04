using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public AudioSource birdNoise;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        birdNoise.Play();
    }
}
