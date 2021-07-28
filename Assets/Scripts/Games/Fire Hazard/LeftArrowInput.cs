using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrowInput : MonoBehaviour
{
    public GameObject ArrowLeft;

    // Update is called once per frame
    void Update()
    {
        ArrowLeft.transform.Translate(0, 1, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ArrowLeft);
    }
}
