using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 15;
    private float inputHorizontal;
    private float inputVertical;
    private float xRange = 15;
    private float zRangeTop = 13;
    private float zRangeBottom = -0.3f;
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
        } else if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
        if(transform.position.z > 13)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        } else if (transform.position.z < zRangeBottom)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y, zRangeBottom);
        }
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * inputVertical);
        transform.Translate(Vector3.right * speed * Time.deltaTime * inputHorizontal);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, new Vector3(transform.position.x,1.5f,transform.position.z), projectilePrefab.transform.rotation);
        }
    }
}
