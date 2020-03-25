using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondEnemySpawner : MonoBehaviour
{
    public GameObject SecondEnemy;
    float randX;
    Vector2 WhereToSpawn1;
    public float spawnRate1 = 2f;
    float nextSpawn1 = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn1)
        {
            nextSpawn1 = Time.time + spawnRate1 + 10f;
            randX = Random.Range(-30.0f,-20.0f);
            WhereToSpawn1 = new Vector2(randX, transform.position.y);
            Instantiate(SecondEnemy, WhereToSpawn1, Quaternion.identity);
        }
    }
}
