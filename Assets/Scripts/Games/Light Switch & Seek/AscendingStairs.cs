using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AscendingStairs : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position += new Vector3(0, -1893, 0);
    }
}


//77, 556

//2074, 813

//