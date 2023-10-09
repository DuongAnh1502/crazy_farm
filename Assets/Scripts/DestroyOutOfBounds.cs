using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float topBound = 30.0f;
    private float botBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } 
        if(transform.position.z < botBound)
        {
            Debug.Log("Game Over!!");
            Destroy(gameObject);
        }
    }
}
