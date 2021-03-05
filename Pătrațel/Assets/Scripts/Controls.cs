using System.Collections;   
using UnityEngine;
//Made by Dologa Razvan
public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float movespeed;
    public float jumpheight;
    public bool moveright;
    public bool moveleft;
    public bool jump;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    public  int crystals;
    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
    void Update()
    {
        animator.SetFloat("Speed",Mathf.Abs(movespeed));
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            rb.velocity = new Vector2(movespeed, rb.velocity.y);                                                                                                                                                                                                                                                                                                                                            //Made by Dologa Razvan
        }

        if (Input.GetKey(KeyCode.Space))
        {

            if (onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);

            }                                                                                                                                                                                                                                                                                                                                         //Made by Dologa Razvan
        }
        if (moveright)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);     //same codes since we are talking about the same type of movement 

        }

        if (moveleft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);

        }
        if (jump)
        {
          if(onGround)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpheight);
                 
                }
            jump = false;

        }
    
    }
}