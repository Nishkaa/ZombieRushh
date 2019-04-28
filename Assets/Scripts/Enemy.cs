using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    // Start is called before the first frame update
 void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
