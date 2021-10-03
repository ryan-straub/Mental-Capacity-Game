using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZoneHWH : MonoBehaviour
{
    public PlayerStress player;
    public bool inZone = false;

    //If player is in collider, then increase total damage of player by 8 points
    private void OnTriggerEnter2D(Collider2D collision)
    {
        inZone = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inZone = false;
    }

    void Update()
    {
        if(inZone == true)
        {
            player.verySmallDamage();
        }
    }

}
