using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PanelSetings : MonoBehaviour
{
    public GameObject PanelSeting;

    public void PanelSetingOn()
    {
        PanelSeting.SetActive(true);
    }

    public void PanelSetingOff()
    {
        PanelSeting.SetActive(false);
    }

}
