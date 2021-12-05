using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventsPoints : MonoBehaviour
{
    public static GameEventsPoints current;
    // Start is called before the first frame update
    void Awake()
    {
        current = this;
    }

    public event Action OnCheckpointTriggerEnter;
    public void checkpointTriggerEnter() {
        if(OnCheckpointTriggerEnter != null) {
            OnCheckpointTriggerEnter();
        }
    }
}
