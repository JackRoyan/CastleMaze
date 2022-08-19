using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedDoorCntrl : MonoBehaviour
{
    public GameObject doorObj;

    public bool canOpen = false;
    public bool isLocked = false;
    public bool isopen = false;

    public KeyController keyObject;

    


    // Update is called once per frame
    void Update()
    {
        if (canOpen && !isLocked)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isopen == false)
                {
                    isopen = true;
                    doorObj.transform.rotation = Quaternion.Euler(-90, -90, 0);
                    SoundControler.Instance.PlaySound(SoundControler.Instance.doorOpen);
                }
                else
                {
                    isopen = false;
                    doorObj.transform.rotation = Quaternion.Euler(-90, 0, 0);
                    SoundControler.Instance.PlaySound(SoundControler.Instance.doorClose);
                }
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canOpen = true;
            if (isLocked)
            {
                if (keyObject.isCollected)
                {
                    isLocked = false;
                    if (isopen == false)
                    {
                        UiManager.Instance.SetPromptText("[E]Open");
                    }
                    else
                    {
                        UiManager.Instance.SetPromptText("[E]Close");
                    }
                }
                else
                {
                    UiManager.Instance.SetPromptText("Find key to unlock this door");
                    UiManager.Instance.SetKeyHint(keyObject.name);
                }
            }
            else
            {
                if (isopen == false)
                {
                    UiManager.Instance.SetPromptText("[E]Open");
                }
                else
                {
                    UiManager.Instance.SetPromptText("[E]Close");
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
