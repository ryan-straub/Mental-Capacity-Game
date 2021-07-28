using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeys : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;
    private IEnumerator coroutine;

    IEnumerator test()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("ranTest");
        StopCoroutine(test());
    }

    IEnumerator enableHitbox()
    {
        left.GetComponent<BoxCollider2D>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        //activates hitbox for half a second
        left.GetComponent<BoxCollider2D>().enabled = false;
        StopCoroutine(enableHitbox());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            left.transform.position += new Vector3(3849, -2318, 0);
            left.GetComponent<Renderer>().material.color = new Color(255, 255, 0);
            StartCoroutine(enableHitbox());
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            left.transform.position -= new Vector3(3849, -2318, 0);
            left.GetComponent<Renderer>().material.color = Color.white;
        }





















//=======================================================================================
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            right.transform.position -= new Vector3(3831, -2320, 0);
            right.GetComponent<Renderer>().material.color = new Color(255, 0, 255);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            right.transform.position += new Vector3(3831, -2320, 0);
            right.GetComponent<Renderer>().material.color = Color.white;
        }
//=======================================================================================
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up.transform.position -= new Vector3(-4324, 1976, 0);
            up.GetComponent<Renderer>().material.color = new Color(0, 255, 255);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            up.transform.position += new Vector3(-4324, 1976, 0);
            up.GetComponent<Renderer>().material.color = Color.white;
        }
//========================================================================================
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down.transform.position += new Vector3(-4314, 1946, 0);
            down.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            down.transform.position -= new Vector3(-4314, 1946, 0);
            down.GetComponent<Renderer>().material.color = Color.white;
        }
//========================================================================================
    }
}