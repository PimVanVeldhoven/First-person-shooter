using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void PlayButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("FinalProduct");
    }
    public void Retry()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("FinalProduct");
    }
    public void MainMenu()
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("Menu");
    }
    public void GameOver()
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("GameOver");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
