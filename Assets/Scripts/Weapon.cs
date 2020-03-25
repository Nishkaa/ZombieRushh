using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform FireStartingPoint;
    public GameObject bulletPrefab;
    public GameObject bulletPrefabLazer;
    public bool Deactivate = false;
    public float waitTilNextFire;
    public float fireSpeed = 16f;
   
    // Update is called once per frame
    void Start()
    {
       

    }
    void Update()
    {
      
            if (Input.GetButton("Fire1"))
            {
                Shoot();
           
        }           
    }
    void Shoot()
    {
        //shooing
        if (waitTilNextFire<=0)
        {
            Instantiate(bulletPrefab, FireStartingPoint.position, FireStartingPoint.rotation);
            waitTilNextFire = 0.25f;
        }
        //fire rate speed of the shooting
        waitTilNextFire -= Time.deltaTime * fireSpeed;
  
    }
    void LazerShoot()
    {
        Instantiate(bulletPrefabLazer, FireStartingPoint.position, FireStartingPoint.rotation);
    }
   
}
