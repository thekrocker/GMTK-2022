using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public int SceneNumber;
    public void PlayButton()
    {
        SceneManager.LoadScene(SceneNumber);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
