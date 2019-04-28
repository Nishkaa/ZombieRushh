using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public int damage = 10;
    public float speed = 20f;
   // public int damage = 40;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        ZombieEnemy enemy = hitInfo.GetComponent<ZombieEnemy>();
        if(enemy != null )
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
  
}
