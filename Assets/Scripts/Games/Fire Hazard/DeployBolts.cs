using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBolts : MonoBehaviour
{

    //https://www.youtube.com/watch?v=E7gmylDS1C4

    public GameObject leftBoltPrefab;
    public GameObject rightBoltPrefab;
    public GameObject upBoltPrefab;
    public GameObject downBoltPrefab;
    public float respawnTimer = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(leftBoltEnemies);
    }

    private void spawnleftBolt()
    {
        GameObject boltL = Instantiate(leftBoltPrefab) as GameObject;
        boltL.transform.position = new Vector2(-5652, 1715);
    }

    IEnumerator leftBoltEnemies()
    {
        while (true){
            yield return new WaitForSeconds(respawnTimer);
            spawnleftBolt();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
