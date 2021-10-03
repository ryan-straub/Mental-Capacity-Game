using System.Collections;
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
    public Sprite jumpLeft;
    public Sprite jumpRight;
    public GameObject player;
    public bool movingRight = true;
    private Vector3 leftDirection;

    //youtube.com/watch?v=Xnyb2f6Qqzg&t=2319s

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        //Checks if the player jumps to prevent infinite jumping in both left and right directions
        if (Input.GetKey(KeyCode.Space) && jumped == false && movingRight == true)
        {
            body.velocity = new Vector2(body.velocity.x, jump);
            jumped = true;
            jumpSFX.Play();
            player.GetComponent<Animator>().Play("Jump Right");
        }
        else if (Input.GetKey(KeyCode.Space) && jumped == false && movingRight == false)
        {
            body.velocity = new Vector2(body.velocity.x, jump);
            jumped = true;
            jumpSFX.Play();
            player.GetComponent<Animator>().Play("Jump Left");
        }

        if (body.velocity.y == 0)
        {
            jumped = false;
            landSFX.Play();
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && jumped == false)
        {
            player.GetComponent<Animator>().Play("Walking Left");
            movingRight = false;

        }
        else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && jumped == false)
         {
            player.GetComponent<Animator>().Play("Walking Right");
            movingRight = true;

            //REFER BACK TO WHEN FIXING ANIMATION FOR PLAYER

            //have a boolean have it start that character is starting facing right
            //use boolean to have it change directions
            //make scale negative and multiply it by negative 1
        }
    }

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
}
