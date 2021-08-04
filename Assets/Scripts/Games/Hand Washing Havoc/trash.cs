using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash : MonoBehaviour
{
    public AudioSource trashSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        trashSFX.Play();
    }
}
