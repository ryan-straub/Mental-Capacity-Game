﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntrusiveThoughts : MonoBehaviour
{
    public GameObject enemy;
    public float enemySpeed;
    public float enemyMovementx;
    public float enemyMovementy;

    //Update is called once per frame
    void Update()
    {
        enemy.transform.Translate(enemyMovementx * enemySpeed, enemyMovementy * enemySpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(enemy);
    }
}