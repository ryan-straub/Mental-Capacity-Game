using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStress : MonoBehaviour
{
    public double distressLevel = 0;
    public bool playerLose = false;
    public GameObject loseScreen;
    public GameObject winScreen;
    public AudioSource winSFX;
    public AudioSource loseSFX;
    public Slider slider;

    public Ranks rank;

    //------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        slider.value = (float)distressLevel;
    }

    public void gameOver()
    {
        loseScreen.SetActive(true);
        Time.timeScale = 0;
        distressLevel = 100;
        Destroy(slider);
    }

    public void youWin()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0;
    }

    //--------------------------------Damage Amounts--------------------------------

    public void verySmallDamage()
    {
        distressLevel += 0.1;
        RankCheck();
    }

    public void smallStressIncrease()
    {
        distressLevel += 2;
        RankCheck();
    }
    public void moderateStressIncrease()
    {
        distressLevel += 8;
        RankCheck();
    }
    public void largeStressIncrease()
    {
        distressLevel += 10;
        RankCheck();
    }
    public void veryLargeStressIncrease()
    {
        distressLevel += 20;
        RankCheck();
    }

    public void instantLose()
    {
        distressLevel += 100;
        RankCheck();
    }
    
    //------------------------Rank Sprite Updates-----------------------------
    public void RankCheck()
    {
        if (distressLevel >= 100)
        {
            gameOver();
        }
        else if (distressLevel >= 86 && distressLevel <= 99)
        {
            rank.setRank("F");
        }
        else if (distressLevel >= 66 && distressLevel <= 85)
        {
            rank.setRank("D");
        }
        else if (distressLevel >= 46 && distressLevel <= 65)
        {
            rank.setRank("C");
        }
        else if (distressLevel >= 26 && distressLevel <= 45)
        {
            rank.setRank("B");
        }
        else if (distressLevel >= 11 && distressLevel <= 25)
        {
            rank.setRank("A");
        }
        else if (distressLevel >= 0 && distressLevel <= 10)
        {
            rank.setRank("S");
        }
    }


}
