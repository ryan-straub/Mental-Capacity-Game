using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject enemy;
    public GameObject shield;
    public AudioSource shieldBoink;

    //When intrusive thought collides with shield, it plays sfx
    private void OnCollisionEnter2D(Collision2D collision)
    {
        shieldBoink.Play();
    }

    //When player pressed left or right key the shield moves either clockwise or counter-clockwise
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            shield.transform.Rotate(0, 0, 45);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            shield.transform.Rotate(0, 0, -45);
        }
    }
}