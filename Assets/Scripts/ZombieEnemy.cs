using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ZombieEnemy : MonoBehaviour
{
   



    public int health = 120;
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
            FindObjectOfType<AudioManager>().Play("EnemyWalking");

        

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
      
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            FindObjectOfType<AudioManager>().Play("EnemyHit");
        }
       
      

        if (col.gameObject.tag.Equals("Bullet") && health <= 0)
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("EnemyDead");
        }
    }

}
