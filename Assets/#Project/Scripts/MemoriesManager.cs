using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MemoriesManager : MonoBehaviour
{
    public int AmountToClear = 4;
    public int memoriesFound = 0;
    public PickUpMemory memory;
    public GameObject video;
    public VideoPlayer videoPlayer;
    public GameObject light6;

    public AudioSource LVL1;
    
    public void MemoryPickedUp()
    {
        memoriesFound += 1;
        checkClearClouds();
    }
 
    void checkClearClouds()
    {
        if (memoriesFound >= AmountToClear)
        {
            gameObject.SetActive(false); 
            light6.SetActive(true); 
            LVL1.enabled = false;

            video.SetActive(true);
            videoPlayer.Play(); 
            videoPlayer.loopPointReached += CheckOver;
        }
    }
 
    void CheckOver(UnityEngine.Video.VideoPlayer videoPlayer)
    {
        video.SetActive(false);
        videoPlayer.Pause();
    }
}
