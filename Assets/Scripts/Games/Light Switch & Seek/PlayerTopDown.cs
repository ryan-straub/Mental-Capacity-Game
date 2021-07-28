using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDown : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;

    void Update()
    {

        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

        //-------------------------------------------------------------
        //if (doorOpen = true)
        //{

        //}
    }

    //----------------------------------------------------------------------------
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
}

