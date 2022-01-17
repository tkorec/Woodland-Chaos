using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloesMenu : MonoBehaviour
{
    public GameObject Panel;

    public void OpenMenu()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
}
