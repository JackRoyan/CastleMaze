using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{    
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level01()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void Level02()
    {
        SceneManager.LoadScene("Level_02");
    }

    public void Level03()
    {
        SceneManager.LoadScene("Level_03");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void HomeScrn()
    {
        SceneManager.LoadScene("MainMenuScreen");
    }
}
