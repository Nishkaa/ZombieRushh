using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            switchWeapons();
        }
        
    }
    void switchWeapons()
    {
        foreach(Transform weapon in transform)
        {
            weapon.gameObject.SetActive(!weapon.gameObject.activeSelf);
        }
    }
}
