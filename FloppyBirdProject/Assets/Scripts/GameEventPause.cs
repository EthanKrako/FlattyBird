using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventPause : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    private void Start() {
        pauseMenu.SetActive(false);
    }

    private void Update() {
        if (Input.GetButtonDown("Pause")) {
            if (!pauseMenu.activeSelf) {
                PauseGame();
            } else {
                ResumeGame();
            }
        }
    }

    private void PauseGame() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    private void ResumeGame() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
