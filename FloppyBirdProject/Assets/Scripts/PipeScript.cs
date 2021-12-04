using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeScript : MonoBehaviour
{
    public GameObject text;
    private int num;
    public int speed = 4;
    public float livingTime = 15;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
    }

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
        num++;
        text.GetComponent<Text>().text = num.ToString();
    }

    void move() {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
