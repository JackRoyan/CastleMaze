using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public bool canCollect = false;
    public bool isCollected;

    void Update()
    {
        if (canCollect && !isCollected)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isCollected = true;
                SoundControler.Instance.PlaySound(SoundControler.Instance.keyCollect);
                UiManager.Instance.SetPromptText("Key Collected");
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canCollect = true;
            UiManager.Instance.SetPromptText("[E]PickUp Key");
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canCollect = false;
            UiManager.Instance.SetPromptText("");
        }
    }
}
