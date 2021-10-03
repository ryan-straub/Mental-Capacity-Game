using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingStairs : MonoBehaviour
{
    public GameObject player;
    public AudioSource descendingStairsSFX;

    //When player collides with top of stairs sprite, it moves their position to the bottom "floor" and plays an SFX
    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position -= new Vector3(0, -2555, 0);
        descendingStairsSFX.Play();
    }
}
