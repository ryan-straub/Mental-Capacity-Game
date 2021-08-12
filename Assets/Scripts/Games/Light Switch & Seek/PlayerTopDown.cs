using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDown : MonoBehaviour
{
    public float speed;
    public AudioSource walk;
    //public GameObject 
    private Rigidbody2D body;

    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{

        //}
        //else if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{

        //}
        //else if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //}
        //else if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //}
        //else if (Input.GetKeyDown(KeyCode.LeftArrow)) && (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //}
        //else if (Input.GetKeyDown(KeyCode.LeftArrow)) && (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //}
        //else if (Input.GetKeyDown(KeyCode.RightArrow)) && (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //}
        //else if (Input.GetKeyDown(KeyCode.RightArrow)) && (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //}
    }

    //----------------------------------------------------------------------------
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        walk.Play();
    }
}

