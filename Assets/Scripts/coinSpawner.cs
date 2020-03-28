using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    public GameObject coin;
    public float xPositionLimit = 0;
    public float xPositionLimit2 = 100;
    public float SpawnCoinRate;
    // Start is called before the first frame update
    void Start()
    {
        StartCoinSpawn();
       
    }
    public void CoinSpawn()
    {
        //spawns in the position where object is located
        Vector2 SpawnPosition = new Vector2(transform.position.x, transform.position.y);
        Instantiate(coin, SpawnPosition, Quaternion.identity);

    }
    // Update is called once per frame
    void Update()
    {
       
    }
        public void StartCoinSpawn()
    {
        InvokeRepeating("CoinSpawn", 1f, SpawnCoinRate);
    }

}
