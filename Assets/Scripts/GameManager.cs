using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private int lives = 0;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        AddLives(3);
        AddScore(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddLives(int value)
    {
        lives += value;
        if(lives <=0)
        {
            Debug.Log("Game Over!!");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}
