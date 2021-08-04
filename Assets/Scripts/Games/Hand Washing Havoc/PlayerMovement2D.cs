﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement2D : MonoBehaviour
{ 
    public float speed;
    public float jump;
    private bool jumped = false;
    private Rigidbody2D body;
    public AudioSource jumpSFX;
    public AudioSource landSFX;

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.Space) && jumped == false)
        {
            body.velocity = new Vector2(body.velocity.x, jump);
            jumped = true;
            jumpSFX.Play();

        }

        if (body.velocity.y == 0)
        {
            jumped = false;
            landSFX.Play();
        }
    }

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
}
