using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //code used:
    //https://youtu.be/VbZ9_C4-Qbo

    public void PlayGame ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
