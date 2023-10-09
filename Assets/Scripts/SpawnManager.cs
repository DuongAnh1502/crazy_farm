using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosZ = 30f;
    private float spawnRangeX = 20f;
    private float spawnRangeZTop = 20f;
    private float spawnRangeZBottom = 2f; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("randomSpawnIntervalVertical", 2, 2f);
        InvokeRepeating("ranndomSpawnIntervalHorizontal", 2, 2f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void randomSpawnIntervalVertical()
    {
        int randomTime = Random.Range(2, 3);
        Invoke("SpawnRandomAnimalVertical", randomTime);
    }
    void ranndomSpawnIntervalHorizontal()
    {
        int randomTime = Random.Range(2, 3);
        Invoke("SpawnRandomAnimalHorizontal", randomTime);
    }
    void SpawnRandomAnimalVertical()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalHorizontal()
    {
        int rotationY;
        int[] spawnPosX = { -30, 30 };
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        int randomSpawnPosX = spawnPosX[Random.Range(0,spawnPosX.Length)];
        if (randomSpawnPosX == 30)
        {
            rotationY = -90;
        }
        else
        {
            rotationY = 90;
        }
        float spawnPosZ = Random.Range(spawnRangeZBottom,spawnRangeZTop);
        Vector3 spawnPos = new Vector3(randomSpawnPosX, 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(new Vector3(0, rotationY, 0)));
    }
}
