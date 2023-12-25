using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForPanel : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    private GameObject CurrentPanel;

    public GameObject ButtonGrup;

    public void EnablePanel(GameObject Panel)
    {
        CurrentPanel = Panel;
        Panel.SetActive(true);
        
        audioSource.PlayOneShot(clip);
        if (ButtonGrup != null)
        {
            ButtonGrup.SetActive(false);
        }

    }

    public void DisablePanel()
    {
        CurrentPanel.SetActive(false);

        audioSource.PlayOneShot(clip);

        if (ButtonGrup != null)
        {
            ButtonGrup.SetActive(true);
        }

       
    }
}
