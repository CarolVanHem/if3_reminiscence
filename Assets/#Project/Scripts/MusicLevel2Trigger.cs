using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLevel2Trigger : MonoBehaviour
{
    public AudioSource music;

    void OnTriggerEnter()
    {
        music.enabled = true;
    }
}
