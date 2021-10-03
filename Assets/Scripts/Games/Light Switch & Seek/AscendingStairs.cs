using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AscendingStairs : MonoBehaviour
{
    public GameObject player;
    public AudioSource AscendingStairsSFX;

    //When player collides with top of stairs sprite, it moves their position to the next "floor" and plays an SFX
    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position += new Vector3(0, -1893, 0);
        AscendingStairsSFX.Play();
    }
}
