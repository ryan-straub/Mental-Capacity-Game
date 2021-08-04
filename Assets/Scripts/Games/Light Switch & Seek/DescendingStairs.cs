using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingStairs : MonoBehaviour
{
    public GameObject player;
    public AudioSource descendingStairsSFX;

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position -= new Vector3(0, -2555, 0);
        descendingStairsSFX.Play();
    }
}
