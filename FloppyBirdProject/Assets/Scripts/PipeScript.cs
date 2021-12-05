using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public int speed = 4;
    public float livingTime = 15;

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
        livingTime -= Time.deltaTime;
        if (livingTime < 0) {
            this.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        GameEventsPoints.current.checkpointTriggerEnter();
    }

    void move() {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
