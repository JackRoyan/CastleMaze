using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManeger : MonoBehaviour
{
    public GameObject spikeObject;
    public GameObject barObject;
    public GameObject bridgeObject;

    public Vector3 trapPosition = new Vector3(0, 0, 0);

    public void SpikeTrapoff()
    {
        trapPosition = spikeObject.transform.position;
        trapPosition.y += -1.524f;
        spikeObject.transform.position = trapPosition;
        SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOff);
    }

    public void SpikeTrapOn()
    {
        trapPosition = spikeObject.transform.position;
        trapPosition.y -= -1.524f;
        spikeObject.transform.position = trapPosition;
        SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOn);
    }

    public void IronBarOn()
    {
        trapPosition = barObject.transform.position;
        trapPosition.y -= -2.285f;
        barObject.transform.position = trapPosition;
        SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOff);
    }

    public void IronBarOff()
    {
        trapPosition = barObject.transform.position;
        trapPosition.y += -2.285f;
        barObject.transform.position = trapPosition;
        SoundControler.Instance.PlaySound(SoundControler.Instance.TrapOff);
    }

    public void BridgeOn()
    {
        bridgeObject.transform.position = new Vector3(-16.1f, -0.46f, 9.56f);
        SoundControler.Instance.PlaySound(SoundControler.Instance.BridgeOnOff);
    }

    public void BridgeOff()
    {
        bridgeObject.transform.position = new Vector3(-16.1f, -0.46f, 6.38f);
        SoundControler.Instance.PlaySound(SoundControler.Instance.BridgeOnOff);
    }
}
