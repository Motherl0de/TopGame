using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    public AudioSource audioSorce;

    public GameObject VolumeSettings;

    private Settings setting;
    public void Awake()
    {
        setting = VolumeSettings.GetComponent<Settings>();
    }

    public void Update()
    {
        audioSorce.volume = setting.volumeVolume;
    }

}
    