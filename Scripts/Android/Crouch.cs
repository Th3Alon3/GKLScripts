using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Animator animator;
    public bool crouch;

    public void Update()
    {
        if(crouch)
        {
            animator.SetBool("IsCrouching", true);
        }else if(!crouch)
        {
            animator.SetBool("IsCrouching", false);
        }
    }
    public void onPress(){
        crouch = true;
    }
    public void onRelease (){
        crouch = false;
    }
}
