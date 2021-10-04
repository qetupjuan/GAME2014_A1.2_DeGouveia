using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonBehaviour : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void OnInstructionsPressed()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void OnMenuPressed()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnQuitPressed()
    {
        SceneManager.LoadScene("Quit");
    }

    public void OnActualQuitPressed()
    {
        Application.Quit();
    }
}

