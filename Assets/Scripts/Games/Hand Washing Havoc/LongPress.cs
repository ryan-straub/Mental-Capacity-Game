using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongPress : MonoBehaviour
{
    public GameObject washButton;
    public float timeHeld;
    public int currentTime;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            timeHeld = Time.time;
        }
        {
            //currentTime = currentTime * Time.deltaTime;
            Debug.Log(currentTime);
        }

        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("Test2");
        }
    }
}
