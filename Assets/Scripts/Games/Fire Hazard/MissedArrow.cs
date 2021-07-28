using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissedArrow : MonoBehaviour
{
    public PlayerStress player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.moderateStressIncrease();
    }
}
