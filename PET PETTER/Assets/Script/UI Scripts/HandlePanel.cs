using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePanel : MonoBehaviour
{
    public GameObject panel;

    // if the panel exists, get the current state and change to the opposite when button is pressed
    public void OpenPanel()
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
        }
    }

}
