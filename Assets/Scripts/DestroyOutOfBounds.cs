using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float botBound = -10.0f;
    private float sizeBound = 35.0f;
    private GameManager gameManager; 
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        if(transform.position.z < botBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        if(transform.position.x > sizeBound || transform.position.x < -sizeBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
