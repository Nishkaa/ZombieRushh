﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2ES : MonoBehaviour
{
    public GameObject Enemy;
    float randX;
    Vector2 WhereToSpawn;
    public float spawnRate = 2000f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-30.0f, 30.0f);
            WhereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(Enemy, WhereToSpawn, Quaternion.identity);
        }
    }
}
