using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemy;
    public float xPositionLimit = 0;
    public float xPositionLimit2 = 100;
    public float SpawnRate;
    void Start()
    {
       //EnemySpawn();
        StartSpawn();
    }
    
public void EnemySpawn()
    {
        
        Vector2 SpawnPosition = new Vector2(transform.position.x, transform.position.y);
        Instantiate(enemy, SpawnPosition, Quaternion.identity);

    }
    public void StartSpawn()
    {
        InvokeRepeating("EnemySpawn", 1f,SpawnRate);
    }
  
}
