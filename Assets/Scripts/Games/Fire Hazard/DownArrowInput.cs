using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownArrowInput : MonoBehaviour
{
    public GameObject ArrowDown;
    public int totalScore;
    public int stressLevel;

    // Update is called once per frame
    void Update()
    {
        ArrowDown.transform.Translate(0, 1, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ArrowDown);
    }
}
