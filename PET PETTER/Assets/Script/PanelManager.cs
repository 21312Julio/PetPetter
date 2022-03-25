using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Open()
    {
        // If panel isn't null, verify the current state and setActive according to the opposite
        if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
        }
    }
}
