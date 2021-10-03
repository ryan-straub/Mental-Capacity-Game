using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public PlayerStress brain;
    public AudioSource damageSFX;

    //When intrusive thought collides with brain, increases stress bar by 8% and plays sfx
    private void OnTriggerEnter2D(Collider2D collision)
    {
        brain.moderateStressIncrease();
        damageSFX.Play();
    }
}
