using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableBubble : MonoBehaviour
{
    public GameObject BreathingBubble;

    public void Disable()
    {
        BreathingBubble.SetActive(false);
    }

    public void Enable()
    {
        BreathingBubble.SetActive(true);
    }
}
