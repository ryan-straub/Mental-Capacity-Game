using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorSingle : MonoBehaviour
{
    public GameObject doorButtonTrigger1;
    public GameObject door;
    public bool gotMilk = false;
    public AudioSource milk;

    // When player get milk, then then an audio que will play to
    // let them know that the door has opened again and that they can complete the level
    private void OnTriggerEnter2D(Collider2D doorTrigger)
    {
        Destroy(door);
        Destroy(doorButtonTrigger1);
        milk.Play();
    }

}
