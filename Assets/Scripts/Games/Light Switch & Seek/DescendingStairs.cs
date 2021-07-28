using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingStairs : MonoBehaviour
{
    public GameObject player;
    public AudioSource walkingDownStairs;

    void Start()
    {
        walkingDownStairs = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position -= new Vector3(0, -2555, 0);
        walkingDownStairs.Play();
    }
}


//6075, 804

//4070, 782

//