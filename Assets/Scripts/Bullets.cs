using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public int damage = 3;
    public float speed = 30f;
    public float leftspeed = -30f;
    
    // public int damage = 40;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (FindObjectOfType<Player>().facingRight)
        {
            rb.velocity = transform.right * speed;
            Destroy(gameObject,0.5f);
        }
        else
        {
            rb.velocity = -transform.right * speed;
            Destroy(gameObject, 0.5f);
        }
      

    }
    void Update()
    {
      
       // if (Input.GetKeyDown(KeyCode.A))
       // {
         //   rb.velocity = transform.right * leftspeed;
       // }
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
