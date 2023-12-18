using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioTrigger : MonoBehaviour
{
    public AudioSource soundEffect;

    void OnTriggerEnter()
    {
        soundEffect.enabled = true;
    }

    void OnTriggerExit ()
    {
        soundEffect.enabled = false;
    }
}
