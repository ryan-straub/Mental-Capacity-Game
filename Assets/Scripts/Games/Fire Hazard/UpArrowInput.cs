using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpArrowInput : MonoBehaviour
{
    public GameObject ArrowUp;
    public int totalScore;
    public int stressLevel;

    // Update is called once per frame
    void Update()
    {
        ArrowUp.transform.Translate(0, -1, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ArrowUp);
    }
}
