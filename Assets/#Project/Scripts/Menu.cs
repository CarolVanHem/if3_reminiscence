using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //public Animator transition;
    //public float transitionTime = 1f;
    public void RunGame()
    {
        //StartCoroutine(LoadLevel(1));
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

/*
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
*/

}
