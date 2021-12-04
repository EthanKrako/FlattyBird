using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpForce;

    private bool isJumping = false;

    public ParticleSystem particle;

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
        // Stop all the other scripts for the gameover screen
        this.enabled = false;
        var pipes = FindObjectsOfType<PipeScript>();
        foreach (var item in pipes)
        {
            item.enabled = false;
        }
        var spawner = FindObjectOfType<PipeSpawner>();
        spawner.enabled = false;
    }

    void Jump(Rigidbody2D rb) {
        rb.velocity = new Vector2(0, jumpForce);
        particle.Clear();
        particle.Play();
    }
}
