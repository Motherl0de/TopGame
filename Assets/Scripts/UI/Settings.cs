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
    public void SetVolumeSeting()
    {
        PlayerPrefs.SetFloat("volumeVolume", SetVolumeVolume.value);
        PlayerPrefs.SetFloat("volumeSound", SetVolumeSound.value);
        PlayerPrefs.SetFloat("volumeSystem", SetVolumeSystem.value);
        PlayerPrefs.SetFloat("volumeGame", SetVolumeGame.value);

        PlayerPrefs.Save();
    }
    public void GetVolumeSeting()
    {
        SetVolumeVolume.value = PlayerPrefs.GetFloat("volumeVolume");
        SetVolumeSound.value = PlayerPrefs.GetFloat("volumeSound");
        SetVolumeSystem.value = PlayerPrefs.GetFloat("volumeSystem");
        SetVolumeGame.value = PlayerPrefs.GetFloat("volumeGame");
    }
     
    public void Start()
    {
      GetVolumeSeting();
    }
}

