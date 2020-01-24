using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public Animator animator;
    public bool facingRight;
    public AudioSource Jumping;
    // Start is called before the first frame update
    //'FixedUpdate' controlling the framerate speed if neccessary

    void Start()
    {
        facingRight = true;
        myRigidbody = GetComponent<Rigidbody2D>();
        Jumping = GetComponent<AudioSource>();
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
            Jumping.Play();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        float horizontal = Input.GetAxis("Horizontal");
        Movement(horizontal);
        animator.SetFloat("Speed",Mathf.Abs(horizontal));
        // animator.SetBool("IsJumping", true);
        turnAround(horizontal);
    }

    //moving left or right
    public void Movement(float horizontal)
    {
        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);
      
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy") )
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("lose");
        }
     
    }
 public void turnAround( float horizontall)
    {
        if(horizontall > 0 && !facingRight || horizontall<0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }

}
   
