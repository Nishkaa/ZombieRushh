using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake_T1 : MonoBehaviour
{
    private float shakeTimeRemaining, shakePower, shakeFadeTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            StartShake(1.0f, 2.0f);
        }
    }
    private void LateUpdate()
    {
        if (shakeTimeRemaining > 0)
        {
            shakeTimeRemaining = Time.deltaTime;
            float xAmount = Random.Range(-0.02f, 0.02f) * shakePower;
            float yAmount = Random.Range(0f, 0f) * shakePower;

            transform.position += new Vector3(xAmount, yAmount, 0f);
            shakePower = Mathf.MoveTowards(shakePower, 0f, shakeFadeTime * Time.deltaTime);
        }
        else
        {
            transform.position += new Vector3(0f, 0f, 0f);
        }
    }
    public void StartShake(float length,float power)
    {
        shakeTimeRemaining = length;
        shakePower = power;
        shakeFadeTime = power / length;
    }
}
