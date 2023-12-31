using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityLight : MonoBehaviour
{
    public GameObject nearLight;
    public AudioSource soundEffect;

    void OnTriggerEnter()
    {
        nearLight.SetActive(true);
        soundEffect.enabled = true;
    }

    void OnTriggerExit ()
    {
        nearLight.SetActive(false);
        soundEffect.enabled = false;
    }
}
