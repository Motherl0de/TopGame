using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public AudioSource audioSorce;

    public Scrollbar ScrollBarValue;

    public Scrollbar VolumVolum;

    public void Update()
    {
        audioSorce.volume = ScrollBarValue.value * VolumVolum.value;
    }

}
    