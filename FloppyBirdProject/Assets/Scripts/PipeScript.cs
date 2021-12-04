using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public int speed = 4;
    public float livingTime = 15;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, livingTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
        livingTime -= Time.deltaTime;
    }

    void move() {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
