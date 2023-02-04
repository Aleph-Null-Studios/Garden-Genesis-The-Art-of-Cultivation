using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Level loader :|
    [SerializeField] LevelLoader loader;

    public void ClickStartButton() {
        // SceneManager.LoadScene(1);
        loader.ClickPlayButton();
    }

    public void ClickOptionsButton() {
        // Open/Close Options Canvas
    }

    public void ClickExitButton() {
        // Close application (WebGL :( no werk)
        Application.Quit();
    }
}
