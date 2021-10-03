using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDown : MonoBehaviour
{
    public float speed;
    public AudioSource walk;
    public GameObject player;
    private Rigidbody2D body;

    //PLAYER ROTATION STILL NEEDS TO BE FIXED
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

        //Up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.GetComponent<Animator>().Play("Moving");
            player.transform.Rotate(0, 0, 0);
        }

        //Left
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player.GetComponent<Animator>().Play("Moving");
            player.transform.Rotate(0, 0, 90);
        }

        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            player.GetComponent<Animator>().Play("Moving");
            player.transform.Rotate(0, 0, -90);
        }

        //Right
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.GetComponent<Animator>().Play("Moving");
            player.transform.Rotate(0, 0, -90);
        }

        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            player.GetComponent<Animator>().Play("Moving");
            player.transform.Rotate(0, 0, 90);
        }

        //Down 
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.GetComponent<Animator>().Play("Moving");
            player.transform.Rotate(0, 0, 180);
        }

        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            player.GetComponent<Animator>().Play("Moving");
            player.transform.Rotate(0, 0, -180);
        }
    //Re-Position
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            player.GetComponent<Animator>().Play("Moving");
            player.transform.Rotate(0, 0, 90);
        }
    }

    //----------------------------------------------------------------------------
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
}

