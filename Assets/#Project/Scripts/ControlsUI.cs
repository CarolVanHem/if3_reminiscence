using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    void OnTriggerExit ()
    {
        controlsText.SetActive(false);
        mouseText.SetActive(false);
    }
    
}
