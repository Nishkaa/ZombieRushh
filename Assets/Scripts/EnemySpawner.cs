using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
   
    public ScoreTextScript scoreTextScript;
    public GameObject Enemy;
    float randX;
    Vector2 WhereToSpawn;
    public float spawnRate = 2f;
    public float nextSpawn = 0.0f;
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
            
            randX = Random.Range(50.0f, 60.0f);
            WhereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(Enemy, WhereToSpawn, Quaternion.identity);
           
        }
        ScoreTextScript score = GetComponent<ScoreTextScript>();
        if (ScoreTextScript.scoreValue == 200)
        {

           
        }
    }
    
     
    
  
}
