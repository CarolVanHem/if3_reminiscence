using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionSceneToMemory1 : MonoBehaviour
{

    public MemoriesManager count;
    void Update()
    {
        if (count.memoriesFound >= 4)
        {
            if(SceneManager.GetActiveScene().buildIndex == 2) 
            {
                SceneManager.LoadScene(3, LoadSceneMode.Additive);
            }
        }
    }
}
