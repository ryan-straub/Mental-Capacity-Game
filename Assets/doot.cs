using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doot : MonoBehaviour
{
    public AudioSource dootSFX;

    private void OnTriggerEnter2D(Collider2D other)
    {
        dootSFX.Play();
    }
}
