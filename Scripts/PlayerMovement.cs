﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	bool crouchfire = false;
	
	
	void Start()
	{
		
		
	}
	

	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}
		if (Input.GetButton("Crouch"))
		{
			crouch = true;
			animator.SetBool("IsCrouching", true);
		}else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
			animator.SetBool("IsCrouching", false);
		}
		if(Input.GetButton("Crouch") && Input.GetButton("Fire1"))
		{
			animator.SetBool("IsCrouching", true);
			animator.SetBool("IsCrouching", true);
		}else if(Input.GetButtonUp("Crouch") && Input.GetButtonUp("Fire1"))
		{
			animator.SetBool("IsCrouching", false);
			animator.SetBool("IsCrouching", false);
		}

		
		
	}
	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching (bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
		
	}
}
