using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompteurScript : MonoBehaviour
{
    public Text text;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        GameEventsPoints.current.OnCheckpointTriggerEnter += OnCheckpointEnter;
    }

    private void OnCheckpointEnter() {
        num++;
        text.text = num.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
