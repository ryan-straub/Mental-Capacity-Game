using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeys : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;
    public GameObject leftLook;
    public GameObject rightLook;
    public GameObject upLook;
    public GameObject downLook;
    private IEnumerator coroutine;

    IEnumerator enableLeftHitbox()
    {
        left.GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        //activates hitbox for half a second
        left.GetComponent<BoxCollider2D>().enabled = false;
        //gameObject.GetComponent<SpriteRenderer>().sprite = leftLook;
        StopCoroutine(enableLeftHitbox());
    }














    IEnumerator enableRightHitbox()
    {
        right.GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        //activates hitbox for half a second
        right.GetComponent<BoxCollider2D>().enabled = false;
        StopCoroutine(enableRightHitbox());
    }

    IEnumerator enableUpHitbox()
    {
        up.GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        //activates hitbox for half a second
        up.GetComponent<BoxCollider2D>().enabled = false;
        StopCoroutine(enableUpHitbox());
    }

    IEnumerator enableDownHitbox()
    {
        down.GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        //activates hitbox for half a second
        down.GetComponent<BoxCollider2D>().enabled = false;
        StopCoroutine(enableDownHitbox());
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            left.SetActive(true);
            StartCoroutine(enableLeftHitbox());
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            left.SetActive(false);
            left.GetComponent<Renderer>().material.color = Color.white;
        }

//=======================================================================================
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            right.SetActive(true);
            StartCoroutine(enableRightHitbox());
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            right.SetActive(false);
            right.GetComponent<Renderer>().material.color = Color.white;
        }

//=======================================================================================
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up.SetActive(true);
            StartCoroutine(enableUpHitbox());
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            up.SetActive(false);
            up.GetComponent<Renderer>().material.color = Color.white;
        }
//========================================================================================
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down.SetActive(true);
            StartCoroutine(enableDownHitbox());
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            down.SetActive(false);
            down.GetComponent<Renderer>().material.color = Color.white;
        }
//========================================================================================
    }
}