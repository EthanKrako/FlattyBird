using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        var bird = FindObjectOfType<PlayerController>();
        bird.Death();
    }
}
