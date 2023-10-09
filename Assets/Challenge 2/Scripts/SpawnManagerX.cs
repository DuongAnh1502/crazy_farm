using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {   
        InvokeRepeating("RandomInterval", startDelay, spawnInterval);
    }
    void RandomInterval()
    {
        spawnInterval = Random.Range(2.0f, 5.0f);
        Invoke("SpawnRandomBall", spawnInterval);
    }
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        spawnInterval = Random.Range(3, 10);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int randomBall = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
    }
    
}
