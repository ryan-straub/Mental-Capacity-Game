using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDown : MonoBehaviour
{
    public float speed;
    public AudioSource walk;
    private Rigidbody2D body;

    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
    }

    //----------------------------------------------------------------------------
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        walk.Play();
    }
}

