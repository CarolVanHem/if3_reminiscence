using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource walkingSound;
    public AudioSource runningSound;
    private Brielle brielle;
    public float newMaxViewDistance = 50;

    void Start()
    {
        brielle = GetComponent<Brielle>();
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
            }
        }
        else
        {
            walkingSound.enabled = false;
            runningSound.enabled = false;
        }

  
    }
}
