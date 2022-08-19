using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapCont : MonoBehaviour
{
    public GameObject trapObject;

    public GameOverSystem GoUI;

    public bool TrapOn = true;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(TrapOn==true)
            {
                GoUI.GameOver();
                SoundControler.Instance.PlaySound(SoundControler.Instance.GameIsOver);
            }
        }
    }
}
