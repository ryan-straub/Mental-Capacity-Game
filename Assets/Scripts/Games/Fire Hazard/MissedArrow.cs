using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissedArrow : MonoBehaviour
{
    public PlayerStress player;

    //When lightning bolt collides with player, increases stress bar by 8% 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.moderateStressIncrease();
    }
}
