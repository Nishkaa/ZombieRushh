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
    
    // Update is called once per frame
    void Start()
    {
       


    }
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        

    }
    void Shoot()
    {
        //shooing
        Instantiate(bulletPrefab, FireStartingPoint.position, FireStartingPoint.rotation);
        
  
    }
    void LazerShoot()
    {
        Instantiate(bulletPrefabLazer, FireStartingPoint.position, FireStartingPoint.rotation);
    }
   
}
