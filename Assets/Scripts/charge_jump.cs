using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charge_jump : MonoBehaviour
{
    private bool onGround;
    private float jumpPressure;
    private float minJump;
    private float maxJumpPressure;
    private Rigidbody2D rbody;
    public Animator animator;
    public bool pressureJumpingHigh;
   public float sec = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        onGround = true;
        jumpPressure = 0f;
        minJump = 5f;
        maxJumpPressure = 20f;
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
            //holding pressure button
            if (Input.GetButton("Fire2"))
            {
                if (jumpPressure < maxJumpPressure)
                {
                    jumpPressure += Time.deltaTime * 10f;

                }
                else
                {
                    jumpPressure = maxJumpPressure;
                }
            }
            //not holding jump button//
            else
            {
                //fire
                if (jumpPressure > 0f)
                {
                    jumpPressure = jumpPressure + minJump;
                    rbody.velocity = new Vector2(jumpPressure / 10, jumpPressure);
                    jumpPressure = 0f;
                    onGround = false;

                }
               
                if (onGround == false)
                {
                    StartCoroutine(JumpTimer());
                }
            }
        }
        IEnumerator JumpTimer()
        {

            yield return new WaitForSeconds(sec);

            onGround = true;
            
        }
    }
    
    
}
