using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void Retry()
    {
        SceneManager.LoadScene("GamePlay");
    }



}
