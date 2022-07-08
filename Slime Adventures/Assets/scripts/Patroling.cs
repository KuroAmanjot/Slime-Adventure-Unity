using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroling : MonoBehaviour
{
    private bool turn; 

    public bool isPatrolling;
    private Rigidbody2D rb;  
    public int walkSpeed;

    public Transform groundCheckObject;
    [SerializeField] private float groundCheckRadius;
    public LayerMask groundLayer; 
    void Start()
    {
        isPatrolling = true;
        rb = GetComponent<Rigidbody2D>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPatrolling == true )
        {
            Patrol();
            
        }
        
    }

    private void FixedUpdate()
    {
        if (isPatrolling)
        {
            turn = ! Physics2D.OverlapCircle(groundCheckObject.position , groundCheckRadius, groundLayer ); 

        }
        


    }
    void Patrol()
    {

        if (turn == true )
        {
            Flip(); 
        }
        rb.velocity = new Vector2(20*walkSpeed * Time.fixedDeltaTime , rb.velocity.y ); 

    }

    void Flip()
    {

        isPatrolling = false; 
        transform.localScale = new Vector2(transform.localScale.x * -1 , transform.localScale.y );
        walkSpeed *= -1;

        isPatrolling = true ;
    }

    private void OnDrawGizmosSelected()
    {


        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(groundCheckObject.position, groundCheckRadius);
    }
}
