using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFH : MonoBehaviour
{
    public GameObject enemy;
    public double distressLevel = 0;
    public GameObject loseScreen;

    // Update is called once per frame
    void Update()
    {
        if (distressLevel >= 100)
        {
            gameOver();
        }
    }

    public void addStress()
    {
        distressLevel += 50;
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        loseScreen.SetActive(true);
    }
}
