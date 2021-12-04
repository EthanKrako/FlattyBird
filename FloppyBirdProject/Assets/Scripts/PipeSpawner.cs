using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    private bool isPlaying = true;
    public float delai;
    private float temps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Time.deltaTime);
        temps -= Time.deltaTime;
        if(isPlaying && (temps < 0)) {
            Instantiate(pipe, new Vector3(transform.position.x,transform.position.y + Random.Range(-5, 5),transform.position.z), new Quaternion());
            temps += delai;
        }
    }
}
