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
    public float jumping;
    void Start()
    {
        
        target = GameObject.FindGameObjectWithTag("PLayer").GetComponent<Transform>();
 
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
            FindObjectOfType<AudioManager>().Play("EnemyWalking");

        ScoreTextScript score = GetComponent<ScoreTextScript>();
        if (ScoreTextScript.scoreValue == 1000)
        {
           
            speed = 8;
            health = 150;
        }
        if (ScoreTextScript.scoreValue == 2000)
        {

            speed = speed * Time.deltaTime + 10;
            health = 200;
        }
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
