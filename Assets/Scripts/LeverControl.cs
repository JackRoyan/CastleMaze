using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverControl : MonoBehaviour
{
    public GameObject trap;
    public GameObject lever;

    public Vector3 trapPosition = new Vector3(0, 0, 0);

    public bool canTurn = false;
    public bool trapOn = true;

    void Update()
    {
        if (canTurn == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (trap.tag=="Spike")
                {
                    if (trapOn == true)
                    {
                        trapPosition = trap.transform.position;
                        trapPosition.y += -1.524f;
                        trap.transform.position = trapPosition;
                        SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOff);
                        lever.transform.rotation = Quaternion.Euler(-60, 0, 0);
                        SoundControler.Instance.PlaySound(SoundControler.Instance.LeverOnOff);
                        trapOn = false;
                    }
                    else
                    {
                        trapPosition = trap.transform.position;
                        trapPosition.y -= -1.524f;
                        trap.transform.position = trapPosition;
                        SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOn);
                        lever.transform.rotation = Quaternion.Euler(-120, 0, 0);
                        SoundControler.Instance.PlaySound(SoundControler.Instance.LeverOnOff);
                        trapOn = true;
                    }
                }
                else if(trap.tag=="Ironbar")
                {
                    if (trapOn == true)
                    {
                        trapPosition = trap.transform.position;
                        trapPosition.y += -2.285f;
                        trap.transform.position = trapPosition;
                        SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOff);
                        lever.transform.rotation = Quaternion.Euler(-60, 0, 0);
                        SoundControler.Instance.PlaySound(SoundControler.Instance.LeverOnOff);
                        trapOn = false;
                    }
                    else
                    {
                        trapPosition = trap.transform.position;
                        trapPosition.y -= -2.285f;
                        trap.transform.position = trapPosition;
                        SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOff);
                        lever.transform.rotation = Quaternion.Euler(-120, 0, 0);
                        SoundControler.Instance.PlaySound(SoundControler.Instance.LeverOnOff);
                        trapOn = true;
                    }
                }
                else
                {
                    if (trapOn == false)
                    {
                        trap.transform.position = new Vector3(-16.1f, -0.46f, 9.56f);
                        SoundControler.Instance.PlaySound(SoundControler.Instance.BridgeOnOff);
                        lever.transform.rotation = Quaternion.Euler(-120, -90, 0);
                        SoundControler.Instance.PlaySound(SoundControler.Instance.LeverOnOff);
                        trapOn = true;
                    }
                    else
                    {
                        trap.transform.position = new Vector3(-16.1f, -0.46f, 6.38f);
                        SoundControler.Instance.PlaySound(SoundControler.Instance.BridgeOnOff);
                        lever.transform.rotation = Quaternion.Euler(-60, -90, 0);
                        SoundControler.Instance.PlaySound(SoundControler.Instance.LeverOnOff);
                        trapOn = false;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canTurn = true;
            UiManager.Instance.SetPromptText("[E]On/Off");
            UiManager.Instance.SetKeyHint(trap.name);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canTurn = false;
            UiManager.Instance.SetPromptText("");
            UiManager.Instance.SetKeyHint("");
        }
    }
}
