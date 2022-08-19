using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManeger : MonoBehaviour
{
    public GameObject GameUI;
    public GameObject pauseUI;

    public SceneController scenCtrl;

    // Start is called before the first frame update
    void Start()
    {
        pauseUI = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameUI.SetActive(false);
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameUI.SetActive(true);
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        Cursor.visible = false;
        scenCtrl.ReloadLevel();
        Time.timeScale = 1;
    }
}
