using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winZone : MonoBehaviour
{
    public GameObject winScreen;

    //When player collides with box, show win screen
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
