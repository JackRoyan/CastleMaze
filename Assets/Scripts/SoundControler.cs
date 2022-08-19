using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControler : MonoBehaviour
{
    private static SoundControler _instance;

    public static SoundControler Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<SoundControler>();
            }

            return _instance;
        }
    }

    public AudioClip LeverOnOff;
    public AudioClip doorOpen;
    public AudioClip doorClose;
    public AudioClip keyCollect;
    public AudioClip TrapOn;
    public AudioClip TrapOff;
    public AudioClip BridgeOnOff;
    public AudioClip WinGame;
    public AudioClip GameIsOver;

    public void PlaySound(AudioClip clipName)
    {
        AudioSource.PlayClipAtPoint(clipName, Camera.main.transform.position);
    }
}
