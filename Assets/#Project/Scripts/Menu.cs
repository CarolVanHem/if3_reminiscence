using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void RunGame()
    {
        SceneManager.LoadScene("VideoStart");
    }

    public void Credits()
    {
        Debug.Log("run credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
