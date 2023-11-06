using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource walkingSound;
    public AudioSource runningSound;
    public Brielle brielle;
    public float newMaxViewDistance = 100;
    public float normalMaxViewDistance;

    void Start()
    {
        normalMaxViewDistance = brielle.maxViewDistance;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                walkingSound.enabled = false;
                runningSound.enabled = true;

                // et alors le vue du monstre augmente ++++++
                brielle.maxViewDistance = newMaxViewDistance;
            }
            else
            {
                walkingSound.enabled = true;
                runningSound.enabled = false;
                brielle.maxViewDistance = normalMaxViewDistance;
            }
        }
        else
        {
            walkingSound.enabled = false;
            runningSound.enabled = false;
        }
    }
}
