using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWelcomeModal : MonoBehaviour
{
    public GameObject Panel;
    public void PanelOpen() 
    {
        if (Panel != null) 
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

    public void PanelClose()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

}
