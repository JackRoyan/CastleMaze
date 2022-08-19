using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    private static UiManager _instance;

    void Update()
    {
        
    }

    public static UiManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UiManager>();
            }

            return _instance;
        }
    }

    public Text promptText;
    public Text keyHintText;

    public void SetPromptText(string textToSet)
    {
        promptText.text = textToSet;
    }

    public void SetKeyHint(string keyToShow)
    {
        keyHintText.text = keyToShow;
    }
}
