using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookHandler : MonoBehaviour
{
    public GameObject Panel;

    public void OpenBooknote()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
}
