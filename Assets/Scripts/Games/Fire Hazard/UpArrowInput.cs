﻿using System.Collections;
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
    void Update()
    {
        ArrowUp.transform.Translate(0, -speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ArrowUp);
    }
}
