using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeys : MonoBehaviour
{
    public PlayerStress playerStress;
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;
    public Sprite centerLook;
    public Sprite leftLook;
    public Sprite rightLook;
    public Sprite upLook;
    public Sprite downLook;
    private IEnumerator coroutine;

    IEnumerator enableLeftHitbox()
    {
        left.GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        //activates hitbox for half a second
        left.GetComponent<BoxCollider2D>().enabled = false;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerStress.moderateStressIncrease();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            left.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().sprite = leftLook;
            StartCoroutine(enableLeftHitbox());
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            left.SetActive(false);
            gameObject.GetComponent<SpriteRenderer>().sprite = centerLook;
            left.GetComponent<Renderer>().material.color = Color.white;
        }

//=======================================================================================
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            right.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().sprite = rightLook;
            StartCoroutine(enableRightHitbox());
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            right.SetActive(false);
            gameObject.GetComponent<SpriteRenderer>().sprite = centerLook;
            right.GetComponent<Renderer>().material.color = Color.white;
        }

//=======================================================================================
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().sprite = upLook;
            StartCoroutine(enableUpHitbox());
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            up.SetActive(false);
            gameObject.GetComponent<SpriteRenderer>().sprite = centerLook;
            up.GetComponent<Renderer>().material.color = Color.white;
        }
//========================================================================================
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().sprite = downLook;
            StartCoroutine(enableDownHitbox());
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            down.SetActive(false);
            gameObject.GetComponent<SpriteRenderer>().sprite = centerLook;
            down.GetComponent<Renderer>().material.color = Color.white;
        }
//========================================================================================
    }
}