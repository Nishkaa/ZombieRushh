using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public int damage = 10;
    public float speed = 30f;
    public float leftspeed = -30f;
    
    // public int damage = 40;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //firing when turn left or right
        rb = GetComponent<Rigidbody2D>();
       
        if (FindObjectOfType<Player>().facingRight)
        {
            //bullet speed
            rb.velocity = transform.right * speed;
          
            Destroy(gameObject,10.0f);
           
        }
       
        else
        {
            rb.velocity = -transform.right * speed;
            Destroy(gameObject, 10.0f);
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
            ScoreTextScript.scoreValue += 10;
           
           
        }
       

    }
 
        
    }
