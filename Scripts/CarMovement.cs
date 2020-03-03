using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    public float maxSpeed;
    public bool facingRight = false;
    public AudioSource carengine;
    public AudioSource carenginehold;

    // Start is called before the first frame update
    void Start()
    {
        carenginehold.Play();
    }

    // Update is called once per frame
    void FixedUpdate () 
    {   
        float move = Input.GetAxis ("Horizontal");
        
        GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
        if (move < 0 && facingRight){
            Flip (); 
            carengine.Play();
            carenginehold.Stop();
        }    
        else if (move > 0 && !facingRight){
            Flip ();
            carengine.Play();
            carenginehold.Stop();
          
        }
        if(move == 0)
        {
            carengine.Stop();
            
        }
        
        
     
     
    }
    void Flip ()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
