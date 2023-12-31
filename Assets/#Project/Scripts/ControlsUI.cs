using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ControlsUI : MonoBehaviour
{
    public GameObject controlsText;
    public GameObject mouseText;
    public GameObject openText;
    public GameObject puText;
    public GameObject runText;

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;

    public GameObject videoMemory;
    public VideoPlayer videoPlayer;

    public AudioSource LVL1;
    public AudioSource LVL2;
    public AudioSource radio;
    public AudioSource creaking;
    public AudioSource switchLight;

    void OnTriggerEnter()
    {
        openText.SetActive(false);
        puText.SetActive(false);
        runText.SetActive(false);

        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
        light5.SetActive(false);
        light6.SetActive(false);

        videoMemory.SetActive(false);
        videoPlayer.Pause();

        LVL1.enabled = true;
        LVL2.enabled = false;
        radio.enabled = false;
        creaking.enabled = false;
        switchLight.enabled = false;
    }

    void OnTriggerExit ()
    {
        controlsText.SetActive(false);
        mouseText.SetActive(false);
    }
    
}
