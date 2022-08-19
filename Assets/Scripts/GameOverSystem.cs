using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSystem : MonoBehaviour
{
    public GameObject GameUI;
    public GameObject gOverUI;
    public GameObject PauseUI;

    public SceneController scenCtrl;

    // Start is called before the first frame update
    void Start()
    {
        gOverUI = transform.GetChild(0).gameObject;
    }    

    public void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameUI.SetActive(false);
        PauseUI.SetActive(false);
        gOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RetryGame()
    {
        Cursor.visible = false;
        scenCtrl.ReloadLevel();
        Time.timeScale = 1;
    }
}
