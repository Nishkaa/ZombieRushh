using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieEnemy : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;
    public float speed;
    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("PLayer").GetComponent<Transform>();

    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
      
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet") && health <= 0)
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

}
