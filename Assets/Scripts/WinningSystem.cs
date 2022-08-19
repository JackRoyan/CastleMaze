using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningSystem : MonoBehaviour
{
    public GameObject GameUI;
    public GameObject gWinUI;
    public GameObject PauseUI;

    public SceneController scenCtrl;

    // Start is called before the first frame update
    void Start()
    {
        gWinUI = transform.GetChild(0).gameObject;
    }

    public void GameWon()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameUI.SetActive(false);
        PauseUI.SetActive(false);
        gWinUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ReplayGame()
    {
        Cursor.visible = false;
        scenCtrl.ReloadLevel();
        Time.timeScale = 1;
    }

    public void NextGame()
    {
        Cursor.visible = false;
        scenCtrl.NextLevel();
        Time.timeScale = 1;
    }
}


