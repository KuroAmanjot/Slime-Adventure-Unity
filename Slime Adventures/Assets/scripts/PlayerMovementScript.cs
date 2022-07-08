using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private CapsuleCollider2D capCollider;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private float movementSpeed;
    [SerializeField]private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;

    private Animator anim ;

    public PauseMenu finishMenu;
    // Start is called before the first frame update

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        capCollider = GetComponent<CapsuleCollider2D>();
        anim = GetComponent<Animator>();

    }
    void Start()
    {


        //rb2D = GetComponent<Rigidbody2D>();
       // movementSpeed = 3f;
       // jumpForce = 30f;
        isJumping = false; 


    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal"); 
        moveVertical = Input.GetAxisRaw("Vertical");

        anim.SetBool("walk", moveHorizontal != 0);
    }

    void FixedUpdate()
    {

        isGrounded();

        if (moveHorizontal > 0.1f|| moveHorizontal< -0.1f  )
        {
            if (moveHorizontal < 0.1f)
            {
                transform.localScale= new Vector3(-.2f, .2f, .2f);
            }

            else if (moveHorizontal > 0.1f)
            {
                transform.localScale = new Vector3(.2f, .2f, .2f);
            }
            rb2D.AddForce(new Vector2(moveHorizontal*movementSpeed , 0f ), ForceMode2D.Impulse);
        }
        if (moveVertical > 0.1 && isGrounded())
        {
            Jump();

        }
    }

    private bool isGrounded()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(capCollider.bounds.center, capCollider.bounds.size, 0 , Vector2.down, 0.1f, groundLayer);
    
        

        return raycast.collider != null;

    }

    private void Jump ( )
    {
        rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);

        anim.SetTrigger("Jump");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "finish ")
        {

           finishMenu.thankyouMenu.SetActive(true);

        }

    }
}
