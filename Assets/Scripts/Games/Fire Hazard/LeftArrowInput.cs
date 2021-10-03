using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowInput : MonoBehaviour
{
    public GameObject ArrowLeft;
    public float speed;

    public void Awake()
    {
        speed = 0.5f;
        Debug.Log(speed);
    }

    // Update is called once per frame
    //Left arrow key moves at fixed speed
    void Update()
    {
        ArrowLeft.transform.Translate(0, speed, 0);
    }

    //When left Lightning Bolt is matched with arrow, then destroy lightning bolt
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ArrowLeft);
    }
}
