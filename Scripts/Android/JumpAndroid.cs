using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndroid : MonoBehaviour
{
   public float jumpforce = 400f; 
   public Rigidbody2D rigidbody;
   public Animator animator;

   public void onClick()
   {
       rigidbody.AddForce(new Vector2(0f, jumpforce));
       animator.SetBool("IsJumping", true);
   }
   
}
