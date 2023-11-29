using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemoriesManager : MonoBehaviour
{
    public int AmountToClear = 4;
    public int memoriesFound = 0;
    public PickUpMemory memory;
    public void MemoryPickedUp()
    {
        memoriesFound += 1;
        checkClearClouds();
    }
 
    void checkClearClouds()
    {
        if (memoriesFound >= AmountToClear)
            gameObject.SetActive(false); 
    }
}
