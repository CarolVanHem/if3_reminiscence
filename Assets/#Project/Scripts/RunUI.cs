using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunUI : MonoBehaviour
{
    public GameObject runText;

    void OnTriggerEnter()
    {
        runText.SetActive(true);
    }

    void OnTriggerExit ()
    {
        runText.SetActive(false);
    }
}
