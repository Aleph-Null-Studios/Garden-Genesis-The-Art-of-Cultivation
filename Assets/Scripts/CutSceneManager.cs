using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutSceneManager : MonoBehaviour
{
    /*Variables*/
    [SerializeField] private Button[] Scenes = new Button[8];           //each scene of the cutscene
    [SerializeField] private AudioClip[] clips = new AudioClip[5];      //each voiceover
    [SerializeField] private GameObject menuCanvas;                     //the actual menu canvas
    private AudioSource audioSource;                                    //audio player

    // Start is called before the first frame update
    void Start()
    {
        //set variables
        audioSource = GetComponent<AudioSource>();

    }//end start

    //selectScene is called on click
    public void SelectScene(int index)
    {
        //disable the main menu visual
        menuCanvas.SetActive(false);


        if(index == Scenes.Length)
        {
           FindObjectOfType<MainMenuController>().GetComponent<MainMenuController>().ClickStartButton();
        }
        if (index != clips.Length) 
        {
            TurnOffSound();
            //play the sound for that scene
            audioSource.PlayOneShot(clips[index]);
        }
        //show the nextScene
        Scenes[index].gameObject.SetActive(true);
    }

    public void TurnOffSound()
    {
        if(audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
