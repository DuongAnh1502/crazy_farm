using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 15;
    private float inputHorizontal;
    private float xRange = 15;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
        inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * inputHorizontal);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, new Vector3(transform.position.x,1.5f,transform.position.z), projectilePrefab.transform.rotation);
        }
    }
}
