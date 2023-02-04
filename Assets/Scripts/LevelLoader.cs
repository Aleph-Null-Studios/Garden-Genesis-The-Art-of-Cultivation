using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    // Scene index to load
    [SerializeField] int SceneIndex = 0;

    // Progress of async loading
    float LoadProgress = 0f;

    // Canvas' to show and hide during loading
    [SerializeField] GameObject HideCanvas;
    [SerializeField] GameObject LoadingCanvas;

    // Slider to show load progress to player
    [SerializeField] Slider LoadingProgressSlider;
    // Text to display load progress to player
    [SerializeField] TextMeshProUGUI LoadingProgressText;

    public void ClickPlayButton() {
        // Start scene loading coroutine
        StartCoroutine(StartLoadingScreen(SceneIndex));
    }

    IEnumerator StartLoadingScreen(int SceneIndex) {
        // Disable main canvas and enable loading canvas
        HideCanvas.SetActive(false);
        LoadingCanvas.SetActive(true);
        
        // Start asycronously loading the next scene
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);

        // Dont allow unity to switch to the scene automatically
        operation.allowSceneActivation = false;

        // While the loading progress is less than 1
        while (LoadProgress < 1f) {
            // Set loading progess to the operatiosn progress
            LoadProgress = Mathf.Clamp01(operation.progress / 0.9f);

            // Set slider value to loading progress value
            LoadingProgressSlider.value = LoadProgress;
            // Set text value to loading progress value
            LoadingProgressText.text = Mathf.Round(LoadProgress * 100).ToString();

            // Waiting for loading to complete
            yield return null;
        }

        // After loading is complete allow unity to switch scenes
        operation.allowSceneActivation = true;
    }
}
