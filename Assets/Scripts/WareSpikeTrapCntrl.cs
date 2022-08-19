using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WareSpikeTrapCntrl : MonoBehaviour
{
    public GameObject WaredObject;

    public Vector3 spikePosition = new Vector3(0, 0, 0);

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            spikePosition = WaredObject.transform.position;
            spikePosition.x += 1.004f;
            WaredObject.transform.position = spikePosition;
            SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOff);           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            spikePosition = WaredObject.transform.position;
            spikePosition.x -= 1.004f;
            WaredObject.transform.position = spikePosition;
            SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOff);
        }
    }
}
