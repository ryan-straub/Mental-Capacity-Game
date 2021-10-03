using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public PlayerStress player;

    //When player collides with invisible box, then they instantly lose the level and the stress meter is increased by 100%
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.instantLose();
    }
}
