using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrowInput : MonoBehaviour
{
    public GameObject ArrowRight;
    public float speed;

    public void Awake()
    {
        speed = 0.5f;
        Debug.Log(speed);
    }

    // Update is called once per frame
    //Right arrow key moves at fixed speed
    void Update()
    {
        ArrowRight.transform.Translate(0, speed, 0);
    }

    //When Right Lightning Bolt is matched with arrow, then destroy lightning bolt
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ArrowRight);
    }
}
