using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimScript : MonoBehaviour
{
    public Animator Muzzle;
    public bool Stop = false;
    // Start is called before the first frame update
    void Start()
    {
        Muzzle = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Muzzle.Play("muzzleFlash");
        }
        else
        {
            Muzzle.Play("Idle_State");
        }
    }
}
