using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    public AudioSource trashSFX;

    //When player collides with sprite, it plays sound effect
    private void OnTriggerEnter2D(Collider2D collision)
    {
        trashSFX.Play();
    }
}
