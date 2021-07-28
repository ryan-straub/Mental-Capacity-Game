using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public PlayerStress brain;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        brain.moderateStressIncrease();
    }
}
