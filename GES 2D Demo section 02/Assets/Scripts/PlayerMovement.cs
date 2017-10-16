﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    private float speed = 8;

    [SerializeField]
    private float jumpHeight = 6;

    private bool isOnGround;

    private Rigidbody2D myRigidbody2D;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }

    // Use this for initialization
    void Start ()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();  
	}
	
	// Update is called once per frame
	void Update ()
    {
        HandlePlayerMovement();

        HandleJump();
    }

    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && isOnGround)
        {
            myRigidbody2D.velocity =
                new Vector2(myRigidbody2D.velocity.x, jumpHeight);

            isOnGround = false;
        }
    }

    private void HandlePlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log("horizontal input: " + horizontalInput);

        myRigidbody2D.velocity =
            new Vector2(speed * horizontalInput, myRigidbody2D.velocity.y);
    }
}
