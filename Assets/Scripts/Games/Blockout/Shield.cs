using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject enemy;
    public GameObject shield;
    public int shieldPosition = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(enemy);
    }

    //void Start()
    //{
    //    shieldPosition1();
    //}

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

        //Debug.Log(shieldPosition);

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    shieldPosition += 1;
        //}
        //else if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    shieldPosition -= 1;
        //}

        //else if (shieldPosition > 8 || shieldPosition < 1)
        //{
        //    shieldPosition = 1;
        //}

        //else if (shieldPosition == 1)
        //{
        //    shieldPosition1();
        //}

        //if (shieldPosition == 2)
        //{
        //    shieldPosition2();
        //}
    }

    //---------------------------------------------------------
    //public void shieldPosition1()
    //{
    //    transform.position = new Vector3(-510, 476, 0);
    //    shield.transform.Rotate(0, 0, 0);
    //}

    //public void shieldPosition2()
    //{
    //    transform.position = new Vector3(-729, 520, 0);
    //    shield.transform.Rotate(0, 0, 1);
    //}

}