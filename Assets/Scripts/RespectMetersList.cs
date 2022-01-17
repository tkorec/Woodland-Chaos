using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespectMetersList : MonoBehaviour
{
    public GameObject Panel;

    public void OpenRespectMeter()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
}
