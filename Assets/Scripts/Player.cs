using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    [SerializeField]
    private float movementSpeed = 8;
    public float jumpHeight;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

  
   
    // Start is called before the first frame update
    //'FixedUpdate' controlling the framerate speed if neccessary
   
        void Start()
    {

        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //ground Checking
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position,groundCheckRadius,groundLayer);



        //jumping
        if (Input.GetButtonDown("Jump") && isTouchingGround == true)
        {

            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpHeight;
        }
        float horizontal = Input.GetAxis("Horizontal");
        Movement(horizontal);
    }

    //moving left or right
    private void Movement(float horizontal)
    {
        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);
      
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy") )
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

}
   
