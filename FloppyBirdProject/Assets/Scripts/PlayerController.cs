﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpForce;
    public CapsuleCollider2D hitbox;

    private bool isJumping = false;

    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rb.velocity.y*4));

        if (Input.GetButton("Jump") && !isJumping) {
            Jump(rb);
            isJumping = true;
        }
        if(Input.GetButtonUp("Jump")) {
            isJumping = false;
        }
    }

    void FixedUpdate() {
        
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        this.enabled = false;
    }

    void Jump(Rigidbody2D rb) {
        rb.velocity = new Vector2(0, jumpForce);
        particle.Clear();
        particle.Play();
    }
}
