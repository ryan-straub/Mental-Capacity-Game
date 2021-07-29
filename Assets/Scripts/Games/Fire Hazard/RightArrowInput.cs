using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrowInput : MonoBehaviour
{
    public GameObject ArrowRight;

    // Update is called once per frame
    void Update()
    {
        ArrowRight.transform.Translate(0, 1, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ArrowRight);
    }
}
