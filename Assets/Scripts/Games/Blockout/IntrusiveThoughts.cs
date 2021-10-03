using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntrusiveThoughts : MonoBehaviour
{
    public GameObject enemy;
    public float enemySpeed;
    public float enemyMovementx;
    public float enemyMovementy;

    //Fixed speed for intrusive thoughts
    public void Awake()
    {
        enemySpeed = 0.5f;
        Debug.Log(enemySpeed);
    }

    //Update is called once per frame
    //Moves intrusuive thought along a fixed speed every single frame
    void Update()
    {
        enemy.transform.Translate(enemyMovementx * enemySpeed, enemyMovementy * enemySpeed, 0);
    }

    //When intrusive thought collides with shield or brain, it destroys the object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(enemy);
    }
}
