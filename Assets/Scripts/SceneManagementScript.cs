using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagementScript : MonoBehaviour
{
    public void MainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayScene()
    {
        SceneManager.LoadScene(1);
    }

    public void PlaySceneChapter1()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
