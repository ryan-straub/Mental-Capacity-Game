﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorSingle : MonoBehaviour
{
    public GameObject doorButtonTrigger1;
    public GameObject door;
    public bool gotMilk = false;

    private void OnTriggerEnter2D(Collider2D doorTrigger)
    {
        Destroy(door);
        Destroy(doorButtonTrigger1);
    }

    //void Update()
    //{
    //    if (gotMilk == true)
    //    {
    //        Destroy(door);
    //        Destroy(doorButtonTrigger1);
    //    }
    //}

}
