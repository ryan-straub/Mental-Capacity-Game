using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpArrowInput : MonoBehaviour
{
    public GameObject ArrowUp;
    public float speed;

    public void Awake()
    {
        speed = 0.5f;
        Debug.Log(speed);
    }

    // Update is called once per frame
    // up arrow key moves at fixed speed
    void Update()
    {
        ArrowUp.transform.Translate(0, -speed, 0);
    }
    //When up Lightning Bolt is matched with arrow, then destroy lightning bolt
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ArrowUp);
    }
}
