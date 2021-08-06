using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployBirds : MonoBehaviour
{
    //https://www.youtube.com/watch?v=E7gmylDS1C4

    public GameObject birdPrefab;
    public float respawnTimer = 3.0f;
    public float height;

    public void Awake()
    {
        height = Random.Range(500.0f, 1200.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(birbs);
    }

    private void spawnBird()
    {
        GameObject birb = Instantiate(birdPrefab) as GameObject;
        //bird.transform.position = new Vector2(7000, height);
    }

    IEnumerator birdsSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTimer);
            //spawnleftBolt();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
