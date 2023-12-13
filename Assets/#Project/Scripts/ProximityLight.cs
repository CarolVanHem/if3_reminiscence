using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityLight : MonoBehaviour
{
    public GameObject nearLight;

    void OnTriggerEnter()
    {
        nearLight.SetActive(true);
    }

    void OnTriggerExit ()
    {
        nearLight.SetActive(false);
    }
}
