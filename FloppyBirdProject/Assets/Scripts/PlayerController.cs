using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpForce;

    private bool isJumping = false;
    private bool isDead = false;

    public ParticleSystem particle;
    public GameObject deathMenu;

    void Start() {
        deathMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rb.velocity.y*4));

        if (Input.GetButton("Jump") && !isJumping && rb.position.y < 9) {
            Jump(rb);
            isJumping = true;
        }
        if(Input.GetButtonUp("Jump")) {
            isJumping = false;
        }
        if (Input.GetButton("Jump") && isDead) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        Death();
    }

    void Jump(Rigidbody2D rb) {
        rb.velocity = new Vector2(0, jumpForce);
        particle.Clear();
        particle.Play();
    }

    public void Death() {
        // Stop all the other scripts for the gameover screen
        deathMenu.SetActive(true);
        var pipes = FindObjectsOfType<PipeScript>();
        foreach (var item in pipes)
        {
            item.enabled = false;
        }
        var spawner = FindObjectOfType<PipeSpawner>();
        spawner.enabled = false;
        isDead = true;
    }
}
