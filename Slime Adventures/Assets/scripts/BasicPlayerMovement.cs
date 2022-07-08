using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float downForce;
    [SerializeField] private float sprintSpeed;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask ceilingLayer;
     
    private bool crouchcheck = false; 
    private float jumpCooldown;
    private Animator anim; 

    private float horizontalAxisInfo;
    //private bool grounded; 
    private Rigidbody2D playerBody;
    private CapsuleCollider2D capCollider;
    private BoxCollider2D headCollider;
    
    
    private void Awake()
    {
        playerBody = GetComponent<Rigidbody2D>(); // getting the component of rigidbody from the object 
        anim = GetComponent<Animator>();
        capCollider = GetComponent<CapsuleCollider2D>();
        headCollider = GetComponent<BoxCollider2D>() ;
    }

    private void FixedUpdate()
    {
        //speed = 5;
        //jumpSpeed = 5;
        horizontalAxisInfo = Input.GetAxis("Horizontal");
        playerBody.velocity = new Vector2(horizontalAxisInfo*speed ,playerBody.velocity.y ); //A or D to move left and right 
         
        if(horizontalAxisInfo <0f)
         {
            transform.localScale= new Vector3(-1f, 1f, 1f);
         }
         else if (horizontalAxisInfo >= 0f)
         {
            transform.localScale = Vector3.one;

         }

       

       
            if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)) && isGrounded() && jumpCooldown > 1.25f ) // jump when space or W is pressed and when the player is touching the ground 
             {
            //playerBody.velocity.y = jumpSpeed ; 
                Jump(); //jump function 
                    
              }   
            else if (Input.GetKey(KeyCode.S))  // cancels jump and give velocity to bring player down to ground 
                 {
                 playerBody.velocity = new Vector2(playerBody.velocity.x, -downForce); // down force is the velocity given to object to get it down(using jump cancel )

                  }
            else if (Input.GetKey(KeyCode.LeftShift)) // sprint => Left Shift + A OR D 
                 {
                playerBody.velocity = new Vector2(horizontalAxisInfo * sprintSpeed, playerBody.velocity.y); // multipling the horizontal axis velocity with the sprint speed to get sprint

               }
            else
            {
                jumpCooldown += Time.deltaTime;

            }


        if (crouchcheck == false )
        {
            
            
                headCollider.enabled = true;
            

        }
 
        crouch();
        anim.SetBool("run", horizontalAxisInfo != 0);
        anim.SetBool("grounded", isGrounded());
        
        anim.SetBool("iscrouching", crouchcheck );


    }



    private void Jump() 
    {
        playerBody.velocity = new Vector2(playerBody.velocity.x, jumpSpeed); //giving jump velocity to y axis
        anim.SetTrigger("jump");
        jumpCooldown = 0;
        //isGrounded();   //= false;  after you jump the ground detection turns false
    }

    private void crouch()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ceilingCheck();
            headCollider.enabled = !headCollider.enabled;
            crouchcheck = true;
            //capCollider.size = new Vector2(capCollider.size.x, 1.1f);
            //capCollider.offset = new Vector2(capCollider.offset.x, -0.35f);
            //headCollider.enabled = false;

        }
        else if (Input.GetKeyUp(KeyCode.C) && !ceilingCheck())
        {
            
            headCollider.enabled = !headCollider.enabled;
            //capCollider.size = new Vector2(capCollider.size.x, 1.7f);
            //capCollider.offset = new Vector2(capCollider.offset.x, -0.05f);
            crouchcheck = false;    
        
        }
        


    }


    private void OnCollisionEnter2D(Collision2D collision) // ground detection function 
    {
        /*if (collision.gameObject.tag == "ground") // when the object collision touches the object with tag "ground"
        {
            isGrounded();  // = true; ground bool turns true and enables ground jump and probably other options in future 
            //Debug.Log("you are touch the ground ");
        }*/
      
    }

    private bool isGrounded()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(capCollider.bounds.center , capCollider.bounds.size, 0 ,Vector2.down, 0.1f, groundLayer);
        return raycast.collider != null;

    }
    private bool ceilingCheck()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(capCollider.bounds.center, capCollider.bounds.size, -90, Vector2.up, 0.3f, ceilingLayer);
        Debug.DrawRay(transform.position, Vector2.up , Color.red);

        /*if (raycast.collider != null) ;
        {
            canCrouch = true; 
        }*/
        
        return raycast.collider != null;

    }
        
            
       
        

}


