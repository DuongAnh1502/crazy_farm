using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosZ = 30f;
    private float spawnRangeX = 20f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 2f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
