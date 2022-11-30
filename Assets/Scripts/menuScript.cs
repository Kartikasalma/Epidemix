using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public string nextScene;
    public void playGame()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
