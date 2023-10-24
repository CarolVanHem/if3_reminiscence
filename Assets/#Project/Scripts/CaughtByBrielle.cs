using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaughtByBrielle : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            Debug.Log("You got caught");
        }
    }
}
