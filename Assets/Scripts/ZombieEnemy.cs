﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieEnemy : MonoBehaviour
{

    public AudioSource hit_hurt;
    public int health = 120;
    public GameObject deathEffect;
    public float speed;
    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("PLayer").GetComponent<Transform>();
        hit_hurt = GetComponent<AudioSource>();

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
        if (col.gameObject.tag.Equals("Bullet"))
        {
            hit_hurt.Play();
        }

        if (col.gameObject.tag.Equals("Bullet") && health <= 0)
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

}
