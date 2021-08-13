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
    void Update()
    {
        ArrowLeft.transform.Translate(0, speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ArrowLeft);
    }
}
