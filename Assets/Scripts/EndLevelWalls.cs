using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelWalls : MonoBehaviour
{
  

    void OnCollisionEnter2D(Collision2D col)
    {
     

        if (col.gameObject.tag.Equals("Bullet"))
        {
            Destroy(col.gameObject);
            
        }
    }
}
