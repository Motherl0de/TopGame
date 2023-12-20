using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Scrollbar SetVolumeVolume;

    public Scrollbar SetVolumeSound;

    public Scrollbar SetVolumeSystem;

    public Scrollbar SetVolumeGame;

    public float volumeVolume;

    public float volumeSound;

    public float volumeSystem;

    public float volumeGame;


    public void SetVolumeSeting()
    {
        volumeVolume = SetVolumeVolume.value;

        volumeSound = SetVolumeSound.value;

        volumeSystem = SetVolumeSystem.value;

        volumeGame = SetVolumeGame.value;

    }
    public void Awake()
    {
       volumeVolume = 0.1f;

       volumeSound = 0.1f;

       volumeSystem = 0.1f;

       volumeGame = 0.1f;

    }
}

