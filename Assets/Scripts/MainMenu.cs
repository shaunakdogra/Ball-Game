using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void Levels()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Play1()
    {
        SceneManager.LoadScene(3);
    }
    public void Play2()
    {
        SceneManager.LoadScene(4);
    }
    public void Play3()
    {
        SceneManager.LoadScene(5);
    }
    public void Play4()
    {
        SceneManager.LoadScene(6);
    }
    public void Play5()
    {
        SceneManager.LoadScene(7);
    }
    public void Play6()
    {
        SceneManager.LoadScene(8);
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}



