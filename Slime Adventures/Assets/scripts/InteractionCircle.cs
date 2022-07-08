using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCircle : MonoBehaviour
{
    public Transform checkingForInteractives;
    public LayerMask interactives;
    public bool canInteract;
    [SerializeField] private float checkInteractiveRadius;
    // Update is called once per frame
    void Update()
    {

        Interactions();
        
    }

    private void FixedUpdate()
    {
        canInteract = Physics2D.OverlapCircle(checkingForInteractives.position, checkInteractiveRadius, interactives); 


    }

    private void OnDrawGizmosSelected()
    {


        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(checkingForInteractives.position , checkInteractiveRadius ); 
    }

    public void Interactions()
    {
        if (Input.GetKeyDown(KeyCode.K) && canInteract )
        {
            print(" interaction occured ");

        }


    }
    
}
