using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalChecker : MonoBehaviour
{
    public WinningSystem WonGame;

    public bool canOpen = false;
    public bool goalLocked = false;

    public KeyController keyObject;

    // Update is called once per frame
    void Update()
    {
        if (canOpen && !goalLocked)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                WonGame.GameWon();
                SoundControler.Instance.PlaySound(SoundControler.Instance.WinGame);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canOpen = true;
            if (goalLocked)
            {
                if (keyObject.isCollected)
                {
                    goalLocked = false;
                    UiManager.Instance.SetPromptText("[E]Escape");
                }
                else
                {
                    UiManager.Instance.SetPromptText("Find key to unlock this door");
                    UiManager.Instance.SetKeyHint(keyObject.name);
                }
            }           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canOpen = false;
            UiManager.Instance.SetPromptText("");
            UiManager.Instance.SetKeyHint("");
        }
    }
}
