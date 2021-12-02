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
        temps = delai;
    }

    // Update is called once per frame
    void Update()
    {
        print(Time.deltaTime);
        temps -= Time.deltaTime;
        if(isPlaying && (temps < 0)) {
            Instantiate(pipe, this.transform);
            temps += delai;
        }
    }
}
