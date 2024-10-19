using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJogos : MonoBehaviour
{
    public void LoadClicker()
    {
        SceneManager.LoadScene("Clicker");
    }

    public void LoadAim ()
    {
        SceneManager.LoadScene("Aim");
    }

    public void LoadFlappyBird ()
    {
        SceneManager.LoadScene("Flappy Bird");
    }

    public void LoadPong ()
    {
        SceneManager.LoadScene("Pong");
    }

    public void LoadWorld ()
    {
        SceneManager.LoadScene("Teste");
    }

    public void Exit()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
