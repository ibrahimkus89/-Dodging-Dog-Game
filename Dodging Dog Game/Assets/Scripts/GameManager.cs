using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOver = true;
        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

    }
}
