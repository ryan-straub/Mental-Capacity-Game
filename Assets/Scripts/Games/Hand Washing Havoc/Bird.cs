using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    public AudioSource birdNoise;

    //When player collides with bird, then it plays an audio clip
    private void OnTriggerEnter2D(Collider2D collision)
    {
        birdNoise.Play();
    }
}
