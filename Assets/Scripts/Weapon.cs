using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform FireStartingPoint;
    public GameObject bulletPrefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Shoot();
        }
     
    }
    void Shoot()
    {
        //shooing
        Instantiate(bulletPrefab, FireStartingPoint.position, FireStartingPoint.rotation);
       
    }
}
