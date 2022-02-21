using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRate;
    public float maxXpos;
    
    void Start()
    {
        StartSpawning();
    }

    
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Spawn();
        //}
    }

    void Spawn()
    {
        float randomX = Random.Range(-maxXpos,maxXpos);

        Vector2 spawnpos = new Vector2(randomX,transform.position.y);
        Instantiate(obstacle,spawnpos,Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("Spawn",1f,spawnRate);
    }
   public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }


}
